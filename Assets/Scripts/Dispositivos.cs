using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Dispositivos : MonoBehaviour
{
    // Start is called before the first frame update
    public bool[]  dispositivosB =  new bool[3];
    public string[] dispositivosS = new string[]{"baño", "cocina", "closet"};
    string[] dispositivosN = new string[]{"azul", "verde", "morado", "amarillo", "rojo"};
    private PhotonView view;
    
    void Start()
    {
        dispositivosB[0] = false;
        dispositivosB[1] = false;
        dispositivosB[2] = false;

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

    [PunRPC]
    public void AbrirPuertas(int key){
        dispositivosB[key] = true;
        string tag = dispositivosN[key];
        GameObject puerta = GameObject.FindWithTag(tag);
        puerta.SetActive(false);
    }
}