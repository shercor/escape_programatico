using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Dispositivos : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[]  dispositivosB =  new bool[5];
    public string[] dispositivosS = new string[]{"baño", "cocina", "closet"};
    string[] dispositivosN = new string[]{"azul", "verde", "lila", "rosa", "rojo"};
    private PhotonView view;
    
    void Start()
    {
        dispositivosB[0] = false;
        dispositivosB[1] = false;
        dispositivosB[2] = false;
        dispositivosB[3] = false;
        dispositivosB[4] = false;

    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponentInParent<PhotonView>();
    }

    public void abrir(int key){
        view.RPC("AbrirPuertas", RpcTarget.All, key);
        // dispositivosB[key] = true;
        // string tag = dispositivosN[key];
        // GameObject puerta = GameObject.FindWithTag(tag);
        // puerta.SetActive(false);
    }

    public void abrirSalida(){
        view.RPC("Salir", RpcTarget.All);
        // dispositivosB[key] = true;
        // string tag = dispositivosN[key];
        // GameObject puerta = GameObject.FindWithTag(tag);
        // puerta.SetActive(false);
    }

    [PunRPC]
    public void AbrirPuertas(int key){
        Debug.Log("Key: " + key);
        //dispositivosB[key] = true;
        string tag = dispositivosN[key];
        Debug.Log("Tag abierto: " + tag);
        GameObject puerta = GameObject.FindWithTag(tag);
        puerta.SetActive(false);
    }

    [PunRPC]
    public void Salir(){
        GameObject puerta = GameObject.FindWithTag("salida");
        puerta.SetActive(false);
    }
}