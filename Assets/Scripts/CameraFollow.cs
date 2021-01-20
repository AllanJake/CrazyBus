using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [Header("Follow Settings")]
    public Transform target;
    public Transform parent;
    public Vector3 offset;
    public float followSpeed = 10f;
    public float lookSpeed = 10f;

    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        parent = transform.parent.transform;
    }

    void LateUpdate()
    {
        if (target)
        {
            MoveToTarget();
        }
    }
    void MoveToTarget()
    {
        Vector3 targetPos = target.position +
            target.forward * offset.z +
            target.right * offset.z +
            target.up * offset.y;

        Vector3 playerRot = target.rotation.eulerAngles;
        Quaternion targetRot = Quaternion.Euler(0.0f, playerRot.y, 0.0f);
        parent.position = Vector3.SmoothDamp(parent.position, targetPos, ref velocity, followSpeed);
        parent.rotation = Quaternion.Lerp(parent.rotation, targetRot, lookSpeed * Time.deltaTime);
    }
}
