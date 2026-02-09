using UnityEngine;

public class GoForward : MonoBehaviour
{
    // Script for the traffic cars to go forward automatically.

    public float speed = -20f;

    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
