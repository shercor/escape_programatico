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
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PlayerManager") , Vector3.zero + new Vector3(1f , 1f, 0f), Quaternion.identity);
        if(scene.buildIndex == 1){
            if (view.IsMine){
                //PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","PlayerManager") , Vector3.zero, Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","ItemManager") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs","ControladorDispositivos") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Animal Online") , Vector3.zero + new Vector3(-2f , 11f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Sumar2 Online") , Vector3.zero + new Vector3(13f , 0f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Var Online") , Vector3.zero + new Vector3(-7.5f , -14f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block SOL Online") , Vector3.zero + new Vector3(3.6f , -5.75f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Restar Online") , Vector3.zero + new Vector3(10.6f , 11.18f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc Litio Online") , Vector3.zero + new Vector3(13.5f , -15.3f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc Helio Online") , Vector3.zero + new Vector3(3f , -5.75f, 0f), Quaternion.identity);
                //PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc SOL1 Online") , Vector3.zero + new Vector3(1.5f , -7.5f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc SOL1 Online") , Vector3.zero + new Vector3(16.39f , 12.81f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Doc SOL3 Online") , Vector3.zero + new Vector3(-7.5f , -0.5f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cofre Animales Online") , Vector3.zero + new Vector3(14.4f , -2.5f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cofre Disney Online") , Vector3.zero + new Vector3(2.25f , -12.39f, 0f), Quaternion.identity);
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Cuestionario 1 Online") , Vector3.zero + new Vector3(-0.99f , 13.03f, -2f), Quaternion.identity);
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
