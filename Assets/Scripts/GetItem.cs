using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Photon.Pun;

public class GetItem : MonoBehaviour
{
    public string item;
    private PhotonView view;
    // Buscar el objeto con el tag "Player"
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponent<PhotonView>();
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        float distanceToPlayer = Vector3.Distance(transform.position, playerObject.transform.position);
        //Debug.Log("Distancia al objeto Player: " + distanceToPlayer);
        //GameObject documentos = GameObject.FindGameObjectWithTag("doc");
        //GameObject PC = GameObject.FindGameObjectWithTag("PC");
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && distanceToPlayer < 1.5f)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                view.RPC("DestruirObjeto", RpcTarget.All);
                // Debug.Log("Item cogido");
                // documentos.transform.GetChild(1).gameObject.transform.GetChild(4).GetComponent<DocRespawn>().activarItem(item);
                // PC.transform.GetChild(1).gameObject.transform.GetChild(4).GetComponent<BlockRespawn>().activarItem(item);
                // PhotonNetwork.Destroy(view);
                // Destroy(gameObject);
            }
        }

        
    }

    [PunRPC]
    void DestruirObjeto()
    {
        GameObject documentos = GameObject.FindGameObjectWithTag("doc");
        GameObject PC = GameObject.FindGameObjectWithTag("PC");
        Debug.Log("Item cogido");
        documentos.transform.GetChild(1).gameObject.transform.GetChild(4).GetComponent<DocRespawn>().activarItem(item);
        PC.transform.GetChild(1).gameObject.transform.GetChild(4).GetComponent<BlockRespawn>().activarItem(item);
        
        PhotonNetwork.Destroy(gameObject);
    }

    
}
