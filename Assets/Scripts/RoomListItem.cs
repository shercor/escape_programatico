using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class RoomListItem : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public RoomInfo info;
    public void SetUp(RoomInfo _info)
    {
        info = _info;
        text.text = _info.Name;
    }

    public void OnClick()
    {
        TestConnect.Instance.JoinRoom(info);
    }
}
