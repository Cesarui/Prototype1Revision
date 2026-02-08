using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Camera follows the driver with an offset.

    public Transform driver;

    private Vector3 cameraOffset = new Vector3(0, 10, -10);

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = driver.position + cameraOffset;
    }
}
