using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class ItemManager : MonoBehaviour
{
    private PhotonView view;
    private int color = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponent<PhotonView>();
        if (color == 1){
            color = 2;
            if (PhotonNetwork.IsMasterClient)
            {
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
            }
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
        }
    }

    public void upColor(){
        Debug.Log("Se entró a UpColor en el Item Manager");
        view.RPC("GenerarBloqueColor", RpcTarget.All);
    }

    [PunRPC]
    void GenerarBloqueColor()
    {
        Debug.Log("Se llamó a la función RPC en el Item Manager: " + color);
        color = 1;
        Debug.Log("Se aumentó el valor de color en el Item Manager: " + color);
    }
}
