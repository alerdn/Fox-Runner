using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalSpeed = 0.03f;
    [SerializeField] private float fowardSpeed = 0.5f;
    private void Update()
    {
        Vector3 targetPosition = transform.position;
        if(Input.GetKey(KeyCode.A))
        {
            targetPosition += Vector3.left * horizontalSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetPosition += Vector3.right * horizontalSpeed;
        }
        targetPosition += Vector3.forward * fowardSpeed;

        transform.position = targetPosition;
    }
}
