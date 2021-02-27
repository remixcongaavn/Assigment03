using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = 0.3f;

    public GameObject car;

    public Transform[] spawnPoint;

    float nextTimeToSpawn = 0f;

    void Start ()
    {
        InvokeRepeating("SpawnCar", 0f, 3f);
    }


    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoint.Length);
        Transform spawnPoints = spawnPoint[randomIndex];

        Instantiate(car, spawnPoints.position, spawnPoints.rotation);
    }

}
