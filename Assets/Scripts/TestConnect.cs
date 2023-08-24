   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class TestConnect : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField roomNameInputField;
    [SerializeField] TMP_Text errorText;
    [SerializeField] TMP_Text roomNameText;
    // Start is called before the first frame update
    void Start()
    {
        print("Connecting to Server.");
        //PhotonNetwork.GameVersion = "0.0.1"; //Basicamente logea a los usuarios a esa versión
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        MenuManager.Instance.OpenMenu("title");
        Debug.Log("Joined Lobby");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason" + cause.ToString());
        //base.OnDisconnected(casue);
    }

    public void CreateRoom()
    {
        if(string.IsNullOrEmpty(roomNameInputField.text)){
            return;
        }
        PhotonNetwork.CreateRoom(roomNameInputField.text);
        MenuManager.Instance.OpenMenu("loading");
    }

    public override void OnJoinedRoom()
    {   
        MenuManager.Instance.OpenMenu("room");
        roomNameText.text = PhotonNetwork.CurrentRoom.Name;
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        errorText.text = "Room Creation Failed: " + message;
        MenuManager.Instance.OpenMenu("error");
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        MenuManager.Instance.OpenMenu("loading");
    }

    public override void OnLeftRoom()
    {
       MenuManager.Instance.OpenMenu("title"); 
    }
}
