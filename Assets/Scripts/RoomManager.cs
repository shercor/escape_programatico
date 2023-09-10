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
                PhotonNetwork.Instantiate(Path.Combine("MapItems","Block Sumar2 Online") , Vector3.zero + new Vector3(0f , 0f, 0f), Quaternion.identity);
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