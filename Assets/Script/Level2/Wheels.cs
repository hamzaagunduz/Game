using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    // Start is called before the first frame update
   
    public bool rotateWheels = true;
    public Transform frontWheel;
    public Transform rearWheel;

    public float rotationSpeed = 100f;

    void Update()
    {
        if (rotateWheels)
        {
            // Tekerleklerin sürekli dönme hareketi
            frontWheel.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            rearWheel.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }

    public void ToggleWheelRotation(bool shouldRotate)
    {
        rotateWheels = shouldRotate;
    }
}
