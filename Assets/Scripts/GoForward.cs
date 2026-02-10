using UnityEngine;

public class GoForward : MonoBehaviour
{
    // Script for the traffic cars to go forward automatically.

    public float speed = -20f;

    void Update()
    {
        // Note to self: Translate is what takes care of moving the object along an axis.
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
