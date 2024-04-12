using System.Collections;
using Photon.Pun;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

public class TestConnection : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting to server");
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Server");
        Debug.Log("my nickanme is " + PhotonNetwork.LocalPlayer.NickName, this);

        if (!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected from server reason " + cause.ToString());
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
    }

}

