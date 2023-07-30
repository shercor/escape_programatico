using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispositivos : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[]  dispositivosB =  new bool[3];
    public string[] dispositivosS = new string[]{"baño", "cocina", "closet"};
    string[] dispositivosN = new string[]{"rojo", "azul", "verde"};
    
    void Start()
    {
        dispositivosB[0] = false;
        dispositivosB[1] = false;
        dispositivosB[2] = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrir(int key){
        dispositivosB[key] = true;
    }
}