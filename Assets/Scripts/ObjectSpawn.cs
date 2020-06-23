using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawn : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObjects()
    {
        int randomNumber;
        randomNumber = Random.Range(0, SpawnObject.Length);
        PositionX = Random.Range(1.55f, -1.55f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        Instantiate(SpawnObject[randomNumber], transform.position, transform.rotation);
    }
}
