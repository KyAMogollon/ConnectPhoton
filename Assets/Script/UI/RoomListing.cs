using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
public class RoomListing : MonoBehaviour
{
    [SerializeField]

    private Text _text;

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        _text.text = roomInfo.Name+"("+ roomInfo.MaxPlayers + ")"  ;
    }
}
