using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BusController : MonoBehaviour
{
    // Each wheel 90.7 kg
    // 4 wheels = 362.8 kg

    // Empty Bus weighs 7122.76kg
    // Epmty Bus remove wheel weight = 6759 kg

    // Full Bus weighs 8923.26 kg
    // Full Bus remove wheel weight = 8560.46 kg

    #region Structs
    [System.Serializable]
    public struct WheelColliders {
        public WheelCollider FL;
        public WheelCollider FR;
        public WheelCollider RL;
        public WheelCollider RR;
    };
    [System.Serializable]
    public struct WheelTransforms
    {
        public Transform FL;
        public Transform FR;
        public Transform RL;
        public Transform RR;
    };
    #endregion

    #region Wheels
    [Header("Wheels")]
    public WheelColliders WCols;
    public WheelTransforms WTrans;
    #endregion

    #region Steering
    [Header("Steering")]
    public float maxSteeringAngle;
    public AnimationCurve steeringCurve;

    private float steeringAngle;
    public float steeringInput;
    public Text steerText;
    public Vector3 steerVec;
    #endregion

    #region Acceleration
    [Header("Acceleration")]
    public float speed;
    public float maxTorque;
    public float maxSpeed;
    public float brakeForce;
    public bool isStopped;
    #endregion


    private InputActions inputActions;
    private Rigidbody rb;

    private void Awake()
    {
        SetupInput();
    }

    private void OnEnable()
    {
        InputSystem.EnableDevice(Accelerometer.current);
    }

    private void OnDisable()
    {
        InputSystem.EnableDevice(Accelerometer.current);
    }
    private void SetupInput()
    {
        rb = GetComponent<Rigidbody>();
        inputActions = new InputActions();
        inputActions.Enable();
        // Steering
        inputActions.Driving.Steering.performed += ctx => steeringInput = ctx.ReadValue<float>();
        inputActions.Driving.Speed.performed += ctx => Accelerate(ctx.ReadValue<float>());

        inputActions.Phone.TouchPress.started += ctx => ProcessTouch(ctx);
        inputActions.Phone.TouchPress.canceled += ctx => Accelerate(0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        steeringInput = Accelerometer.current.acceleration.ReadValue().x;
        steerText.text = steeringInput.ToString();
        speed = GetSpeed();        
        UpdateWheelPositions();
        Steer();
    }

    #region Wheels Update
    private void UpdateWheelPositions()
    {
        UpdateTyrePos(WCols.FL, WTrans.FL);
        UpdateTyrePos(WCols.FR, WTrans.FR);
        UpdateTyrePos(WCols.RL, WTrans.RL);
        UpdateTyrePos(WCols.RR, WTrans.RR);

        UpdateWheelPos(WCols.FL, WTrans.FL, true);
        UpdateWheelPos(WCols.FR, WTrans.FR, true);
        UpdateWheelPos(WCols.RL, WTrans.RL, false);
        UpdateWheelPos(WCols.RR, WTrans.RR, false);
    }

    private void UpdateTyrePos(WheelCollider col, Transform tran)
    {
        Vector3 pos = tran.position;
        Quaternion quat = tran.rotation;

        col.GetWorldPose(out pos, out quat);

        tran.position = pos;
        tran.rotation = Quaternion.Euler(quat.eulerAngles.x, quat.eulerAngles.y, quat.eulerAngles.z - 90.0f);
    }

    private void UpdateWheelPos(WheelCollider col, Transform tran, bool front)
    {
        Vector3 pos = tran.position;
        Quaternion quat = tran.rotation;

        col.GetWorldPose(out pos, out quat);

        tran.position = pos;
        if (front)
        {
            tran.rotation = Quaternion.Euler(0, quat.eulerAngles.y, 0);
        }
            tran.rotation = Quaternion.Euler(quat.eulerAngles.x, quat.eulerAngles.y, quat.eulerAngles.z - 90.0f); 
    }
    #endregion

    #region Steering Update
    private void Steer()
    {
        AdaptiveSteering();
        if (WCols.FR.isGrounded && WCols.FL.isGrounded)
        {
            steeringAngle = maxSteeringAngle * steeringInput;
        }

        WCols.FR.steerAngle = steeringAngle;
        WCols.FL.steerAngle = steeringAngle;
    }

    private void AdaptiveSteering()
    {
        // less steering at higher speeds
    }

    #endregion

    #region Acceleration & Braking
    private void Accelerate(float input)
    {
        if (speed <= 0.1f && input <= 0f)
            isStopped = true;

        if (input > 0.0f)
        {
            isStopped = false;
            SetMotorTorque(input);
        }

        if (input < 0f && !isStopped)
        {
            SetBrakeTorque(-input);
        }

        if (input == 0.0f)
        {
            SetMotorTorque(0f);

            SetBrakeTorque(0f);
        }

        if (isStopped && input < 0f)
        {
            SetMotorTorque(-0.5f);
        }
    }

    private void SetMotorTorque(float input)
    {
        WCols.FL.motorTorque = maxTorque * input;
        WCols.FR.motorTorque = maxTorque * input;
        WCols.RL.motorTorque = maxTorque * input;
        WCols.RR.motorTorque = maxTorque * input;
    }

    private void SetBrakeTorque(float input)
    {
        WCols.FL.brakeTorque = brakeForce * input;
        WCols.FR.brakeTorque = brakeForce * input;
        WCols.RL.brakeTorque = brakeForce * input;
        WCols.RR.brakeTorque = brakeForce * input;
    }

    private float GetSpeed()
    {
        return rb.velocity.sqrMagnitude;
    }
    #endregion

    private void ProcessTouch(InputAction.CallbackContext ctx)
    {
        int screenMiddle = 0;
        screenMiddle = Screen.width / 2;

        if (inputActions.Phone.TouchPosition.ReadValue<Vector2>().x >  screenMiddle)
        {
            Accelerate(1f);
        }
        if (inputActions.Phone.TouchPosition.ReadValue<Vector2>().x < screenMiddle)
        {
            Accelerate(-1f);
        }

    }

}
