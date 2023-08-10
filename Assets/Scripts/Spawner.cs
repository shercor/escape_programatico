using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject colorPrefab;
    public GameObject docTren;
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

    public void spawnear(GameObject doc, Vector3 pos){
        Debug.Log("Hola mundo");
        Debug.Log(pos);
        GameObject spawnedObject = Instantiate(doc, pos, Quaternion.identity);
    }

    public void color(Vector3 pos){
        Debug.Log("Hola mundo");
        Debug.Log(pos);
        GameObject spawnedObject = Instantiate(colorPrefab, pos, Quaternion.identity);
    }

    public void abrirPuerta(string tag){
        GameObject puerta = GameObject.FindWithTag(tag);
        puerta.SetActive(false);
    }
}
