using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class ItemManager : MonoBehaviour
{
    private PhotonView view;
    private int color = 0;
    private int menos = 0;
    private int sol4 = 0;
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
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(15.75f , 3.6f, 0f), Quaternion.identity);
            }
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
        }
        if (menos == 1){
            menos = 2;
            if (PhotonNetwork.IsMasterClient)
                {
                    PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc SOL2 Online") , Vector3.zero + new Vector3(12.4f , 11f, 0f), Quaternion.identity);
                }
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
        }
        if (sol4 == 1){
            sol4 = 2;
            if (PhotonNetwork.IsMasterClient)
                {
                    PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc SOL4 Online") , Vector3.zero + new Vector3(-6.2f , 2.62f, 0f), Quaternion.identity);
                }
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Color Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
        }
    }

    public void upColor(){
        Debug.Log("Se entró a UpColor en el Item Manager");
        view.RPC("GenerarBloqueColor", RpcTarget.All);
    }

    public void upMenos(){
        Debug.Log("Se entró a Menos en el Item Manager");
        view.RPC("GenerarBloqueMenos", RpcTarget.All);
    }

    public void upDocSol4(){
        Debug.Log("Se entró a Sol4 en el Item Manager");
        view.RPC("GenerarDocSol4", RpcTarget.All);
    }

    [PunRPC]
    void GenerarBloqueColor()
    {
        Debug.Log("Se llamó a la función RPC en el Item Manager: " + color);
        color = 1;
        Debug.Log("Se aumentó el valor de color en el Item Manager: " + color);
    }

        [PunRPC]
    void GenerarBloqueMenos()
    {
        Debug.Log("Se llamó a la función RPC en el Item Manager: " + menos);
        menos = 1;
        Debug.Log("Se aumentó el valor de color en el Item Manager: " + menos);
    }

    [PunRPC]
    void GenerarDocSol4()
    {
        Debug.Log("Se llamó a la función RPC en el Item Manager: " + sol4);
        sol4 = 1;
        Debug.Log("Se aumentó el valor de color en el Item Manager: " + sol4);
    }
}
