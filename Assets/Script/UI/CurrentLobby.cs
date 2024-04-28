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
    [SerializeField] SOSkin elGuardado;

    public void OnEnable()
    {
        sala.text = "RoomName: " + PhotonNetwork.CurrentRoom.Name;
        nickname.text="NickName: " + PhotonNetwork.NickName;
        
        
    }

    private void Start()
    {
        GameObject MuestraDeSkin = Instantiate(elGuardado.Skin, transform);

        //MuestraDeSkin = Instantiate(laSkin, transform);
        MuestraDeSkin.transform.localPosition = new Vector3(-535, -266, -548);
    }

}