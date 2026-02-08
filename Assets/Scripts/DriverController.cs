 using UnityEngine;

public class DriverController : MonoBehaviour
{
    // Notes: Vector3 is a way to represent 3D space coordinates.

    public int speed = 40;
    public float turnSpeed = 0;
    public float horizontalInput;
    public float forwardInput;
    void Start()
    {
        Debug.Log("Starting position: " + transform.position.ToString());
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Will move the vehicle forward.
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        // horizontalInput can only be -1, 0 or 1 which is why the car won't move even if turnSpeed is above 0 because if horizontal is 0
        // it will all be 0.
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        //Debug.Log(transform.position.ToString());


        // Added these if statements just for information.
        if (horizontalInput != 0)
        {
            Debug.Log("Current Rotation along the Y: " + transform.rotation.y.ToString() 
                 + "\nCurrent Position along the Z: " + transform.position.z.ToString());
        }
        if (transform.position.y > 10)
        {
            Debug.Log("Player is OFF the ground");
        }
    }
}
