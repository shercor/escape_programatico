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
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","Player") , Vector3.zero, Quaternion.identity);
            Debug.Log("Pj instanciado para player: " + photonView.Owner);
        } else {
            Debug.Log("No se va a instanciar pj para "+ photonView.Owner);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
