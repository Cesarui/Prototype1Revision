using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DriverController : MonoBehaviour
{
    // Notes: Vector3 is a way to represent 3D space coordinates.

    private int speed = 15;
    private float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody rb;

    public Camera secondCamera;

    void Start()
    {
        // Makes sure it's enabled once the game starts.
        secondCamera.enabled = true;

        // A reference the car's rigid body.
        rb = GetComponent<Rigidbody>();

        // Outputs the starting position of the car.
        Debug.Log("Starting position: " + transform.position.ToString());
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward.
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        // Rotates the car.
        // Note to self: horizontalInput can only be -1, 0 or 1 which is why the car won't move even if turnSpeed is above 0 because if horizontal is 0
        // it will all be 0. Also Rotate is what takes care of rotation along an axis.
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);

        // Rotation and Position feedback.
        if (horizontalInput != 0)
        {
            Debug.Log("Current Rotation along the Y: " + transform.rotation.y.ToString() 
                 + "\nCurrent Position along the Z: " + transform.position.z.ToString());
        }

        // There is a more efficient way like having a boolean and keeping track if it was pressed.
        // For now I just want to be as straightforward as I can.
        if (Input.GetKey(KeyCode.Q))
        {
            secondCamera.enabled = false;
        }
        if (Input.GetKey(KeyCode.E))
        {
            secondCamera.enabled = true;
        }

    }
    
}
