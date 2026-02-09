using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    public GameObject trafficCar;

    public float cooldown = 5f;

    float time = 0;
    bool timeStarted = false;

    public void Spawn(GameObject gameObject)
    {
        Instantiate(gameObject, new Vector3(5, 0, 180), new Quaternion(0, 1, 0, 0));
    }

    public void Start()
    {
        timeStarted = true;
        Spawn(trafficCar);
    }

    private void Update()
    {
        time += Time.deltaTime;
        Debug.Log("Time: " + time.ToString());

        if (timeStarted == true && time == cooldown)
        {
            Debug.Log("Spawned Car");
            //Spawn(TrafficCar);
            time = 0;
        }

        
    }
}
