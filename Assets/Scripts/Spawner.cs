using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    public GameObject trafficCar;

    public float cooldown = 5f;

    float time = 0;

    // Spwans a traffic car. 
    public void Spawn(GameObject gameObject)
    {
        Instantiate(gameObject, transform.position, transform.rotation);
    }
    public void Start()
    {
        Spawn(trafficCar);
    }

    private void Update()
    {
        time += Time.deltaTime;
        Debug.Log("Time: " + time.ToString());

        // Checks if time reached cooldown to decrease it by that number and simulate cooldown
        if (time > cooldown)
        {
            Spawn(trafficCar);
            time -= cooldown;
        }
    }

}
