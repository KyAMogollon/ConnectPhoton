using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
//public class RoomListing : MonoBehaviour
//{
//    [SerializeField]

//    private Text _text;



//    public void SetRoomInfo(RoomInfo roomInfo)
//    {
//        _text.text = roomInfo.Name+"("+ roomInfo.MaxPlayers + ")"  ;
//    }
//}


public class RoomListing : MonoBehaviour
{
    [SerializeField] Text _text;

    public void SetTex(Text newText)
    {
        _text.text = newText.text;
    }

    public RoomInfo RoomInfo { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo)
    {

        RoomInfo = roomInfo;
        _text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }
}