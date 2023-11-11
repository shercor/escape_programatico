using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        //if (Photon)
        photonView = GetComponent<PhotonView>();
        Debug.Log(photonView.IsMine);
        if (photonView.IsMine){
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","Player") , Vector3.zero + new Vector3(1f , 1f, 0f), Quaternion.identity);
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Animal Online") , Vector3.zero + new Vector3(-6.7f , 6.7f, 0f), Quaternion.identity);
            Debug.Log("Pj instanciado para player: " + photonView.Owner);
        } else {
            Debug.Log("No se va a instanciar pj para "+ photonView.Owner);
        }
        if (PhotonNetwork.IsMasterClient){
            //PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Animal Online") , Vector3.zero + new Vector3(-6.7f , 6.7f, 0f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
