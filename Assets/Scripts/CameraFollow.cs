using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Camera follows the driver with an offset.

    public Transform driver;

    public Vector3 cameraOffset = new Vector3(0, 10, -10);


    // Tried working on the camera following the drivers rotation, is a bit complicated so I won't keep persisting right now.
    // float driverYRotation = 0f;
    //float maxY = 20;

    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = driver.position + cameraOffset;
    }
}
