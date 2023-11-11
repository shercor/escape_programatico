using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using System.IO;


public class Switch : MonoBehaviour
{
    public Toggle t1, t2, t3, t4, t5;
    bool t1s, t2s, t3s, t4s, t5s;
    public TextMeshProUGUI mensaje;
    public GameObject switch2;
    public GameObject item;
    public GameObject spawner;
    private PhotonView view;
    private string nombre;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponentInParent<PhotonView>();
        t1s = t1.isOn;
        t2s = t2.isOn;
        t3s = t3.isOn;
        t4s = t4.isOn;
        t5s = t5.isOn;   
    }

    public void validar(){
        Debug.Log(t1s + "" + t2s + "" + t3s + "" + t4s + "" + t5s);
        if (!t1s && t2s && !t3s && !t4s && !t5s){
            Debug.Log("LO LOGRASTE!");
            mensaje.text = "Cofre abierto";
            mensaje.color = Color.green;
            // spawner = GameObject.FindWithTag("Spawner");
            // spawner.GetComponent<Spawner>().spawnear(item,switch2.transform.position); // Se da GameObject a spawnear y ubicación en V3 donde spawnear
            // Destroy(switch2.gameObject, 2f);
            view.RPC("DestruirObjeto", RpcTarget.All);
        } else {
            mensaje.text = "Cofre no se abre";
            mensaje.color = Color.red;
            Debug.Log("Nope :/");
        }
    }

    [PunRPC]
    void DestruirObjeto()
    {
        if (PhotonNetwork.IsMasterClient)
            {
                nombre = item.name;
                Debug.Log("Spawn de: " + nombre);
                PhotonNetwork.Instantiate(Path.Combine("MapItems",nombre + " Online") , transform.parent.position + new Vector3(-0f , 0f, 2f), Quaternion.identity);
                PhotonNetwork.Destroy(switch2.gameObject);
            }
            else
            {
                view.RPC("RequestMasterClientDestroy", RpcTarget.MasterClient);
            }
    }

    [PunRPC]
    void RequestMasterClientDestroy()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            nombre = item.name;
            Debug.Log(nombre);
            PhotonNetwork.Instantiate(Path.Combine("MapItems",nombre + " Online") , transform.parent.position + new Vector3(-0f , 0f, 2f), Quaternion.identity);
            PhotonNetwork.Destroy(switch2.gameObject);
        }
    }

    private void OnToggleValueChanged(bool newValue)
    {
        if (newValue)
        {
            Debug.Log("Toggle activado");
        }
        else
        {
            Debug.Log("Toggle desactivado");
        }
    }
}
