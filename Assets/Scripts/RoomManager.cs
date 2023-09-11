using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.IO;

public class RoomManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private PhotonView view;
    public static RoomManager Instance;

    void Awake(){
        if(Instance){ //Chequea si existe otro RoomManager. Si ya existe, se destruye
            Destroy(gameObject); 
            return;
        }
        DontDestroyOnLoad(gameObject); //Lo hace indestructible si es el único
        view = GetComponent<PhotonView>();
        Instance = this;
    }

    public override void OnEnable()
    {
        base.OnEnable();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PlayerManager") , Vector3.zero, Quaternion.identity);
        if(scene.buildIndex == 1){
            if (view.IsMine){
                //PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PlayerManager") , Vector3.zero, Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","ItemManager") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","ControladorDispositivos") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Animal Online") , Vector3.zero + new Vector3(-6.7f , 6.7f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Sumar2 Online") , Vector3.zero + new Vector3(13f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Var Online") , Vector3.zero + new Vector3(-9f , -3f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cofre Animales Online") , Vector3.zero + new Vector3(11f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cofre Disney Online") , Vector3.zero + new Vector3(2f , -8f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cuestionario 1 Online") , Vector3.zero + new Vector3(-5f , 10f, 0f), Quaternion.identity);
            }
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
