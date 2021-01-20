using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WheelColliderProperties : MonoBehaviour
{
    public float mass = 90.7f;
    public float radius = 0.52f;
    public float wheelDampingRate = 0.25f;
    public float suspensionDistance = 0.3f;
    public float forceAppPointDistance = 0f;

    [Space(10)]
    public Vector3 center;

    [Space(10)]
    [Header("Suspension Spring")]
    public float spring = 35000f;
    public float damper = 4500f;
    public float targetPosition = 0.3f;

    [Space(10)]
    [Header("Forward Friction")]
    public float fExtremumSlip = 0.4f;
    public float fExtremumValue = 1f;
    public float fAsymptoteSlip = 0.8f;
    public float fAsymptoteValue = 0.5f;
    public float fStiffness = 1f;

    [Space(10)]
    [Header("Sideways Friction")]
    public float sExtremumSlip = 0.4f;
    public float sExtremumValue = 1f;
    public float sAsymptoteSlip = 0.8f;
    public float sAsymptoteValue = 0.5f;
    public float sStiffness = 1f;


    private BusController busController;
    private WheelCollider[] wCols;

    private WheelFrictionCurve forwardFriction;
    private WheelFrictionCurve sidewaysFriction;
    private JointSpring suspension;

    // Start is called before the first frame update
    void OnEnable()
    {
        wCols = new WheelCollider[4];
        busController = GetComponent<BusController>();
        if (busController)
        {
            wCols[0] = busController.WCols.FL;
            wCols[1] = busController.WCols.FR;
            wCols[2] = busController.WCols.RL;
            wCols[3] = busController.WCols.RR; 
        }

        forwardFriction = new WheelFrictionCurve();
        sidewaysFriction = new WheelFrictionCurve();
        suspension = new JointSpring();
    }

    // Update is called once per frame
    void Update()
    {
        suspension.spring = spring;
        suspension.damper = damper;
        suspension.targetPosition = targetPosition;

        forwardFriction.extremumSlip = fExtremumSlip;
        forwardFriction.extremumValue = fExtremumValue;
        forwardFriction.asymptoteSlip = fAsymptoteSlip;
        forwardFriction.asymptoteValue = fAsymptoteValue;
        forwardFriction.stiffness = fStiffness;

        sidewaysFriction.extremumSlip = sExtremumSlip;
        sidewaysFriction.extremumValue = sExtremumValue;
        sidewaysFriction.asymptoteSlip = sAsymptoteSlip;
        sidewaysFriction.asymptoteValue = sAsymptoteValue;
        sidewaysFriction.stiffness = sStiffness;

        for (int i = 0; i < 4; i ++)
        {
            wCols[i].mass = mass;
            wCols[i].radius = radius;
            wCols[i].wheelDampingRate = wheelDampingRate;
            wCols[i].suspensionDistance = suspensionDistance;
            wCols[i].forceAppPointDistance = forceAppPointDistance;

            wCols[i].center = center;

            wCols[i].suspensionSpring = suspension;

            wCols[i].forwardFriction = forwardFriction;
            wCols[i].sidewaysFriction = sidewaysFriction;
        }
    }
}
