using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int cantidadHijosDirectos = transform.childCount;
        if (transform.tag == "slot"){
                if (cantidadHijosDirectos != 0){
                        Destroy(transform.gameObject.transform.GetChild(0).gameObject);
                }
        }
    }
}
