using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void llave(Vector3 pos){
        Debug.Log("Hola mundo");
        Debug.Log(pos);
        GameObject spawnedObject = Instantiate(objectToSpawn, pos, Quaternion.identity);
    }
}
