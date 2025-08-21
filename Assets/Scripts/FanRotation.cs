using UnityEngine;

public class FanRotation : MonoBehaviour
{
    public float rotationSpeed = 150f; // You can adjust this speed

    void Update()
    {
        // Rotate around the Z-axis (assuming the fan blades rotate on Z-axis)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
