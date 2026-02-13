using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DriverController : MonoBehaviour
{
    // Notes: Vector3 is a way to represent 3D space coordinates.
    // RigidBody is a component & camera is another component, but both of things belong to a GameObject.

    [SerializeField] private int speed = 15;
    [SerializeField] private float turnSpeed = 40;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] private string horizontalAxis = "Horizontal";
    [SerializeField] private string verticalAxis = "Vertical";

    private Rigidbody rb;

    [SerializeField] private Camera secondCamera;
    [SerializeField] private KeyCode cameraOnKey = KeyCode.E;
    [SerializeField] private KeyCode cameraOffKey = KeyCode.G;

    void Start()
    {
        // Makes sure it's disabled once the game starts so the player only sees the main camera.
        secondCamera.enabled = false;

        // A reference the car's rigid body.
        rb = GetComponent<Rigidbody>();

        // Outputs the starting position of the car.
        Debug.Log("Starting position: " + transform.position.ToString());
    }

    void Update()
    {
        horizontalInput = Input.GetAxis(horizontalAxis);
        forwardInput = Input.GetAxis(verticalAxis);

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
        if (Input.GetKey(cameraOffKey))
        {
            secondCamera.enabled = false;
        }
        if (Input.GetKey(cameraOnKey))
        {
            secondCamera.enabled = true;
        }

    }
    
}
