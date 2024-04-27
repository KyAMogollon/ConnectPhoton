using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
public class CurrentLobby : MonoBehaviour
{
    public TMP_Text sala;
    public TMP_Text nickname;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnEnable()
    {
        sala.text = "RoomName: " + PhotonNetwork.CurrentRoom.Name;
        nickname.text="NickName: " + PhotonNetwork.NickName;
    }
}