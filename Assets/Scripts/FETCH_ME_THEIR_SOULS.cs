using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FETCH_ME_THEIR_SOULS : MonoBehaviour
{

    public GameObject objectToSpawn;

    public float timeToSpawn;
    private float currentTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
       if (currentTimeToSpawn > 0)
       {
            currentTimeToSpawn -= Time.deltaTime;
       } else
       {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
       }
    }

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
    }
}
