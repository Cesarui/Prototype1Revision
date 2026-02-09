using UnityEngine;

public class Despawner : MonoBehaviour
{
    // Destroys an object when it enter the trigger.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
