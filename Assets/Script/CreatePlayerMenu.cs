using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class CreatePlayerMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _InputplayerName;
    [SerializeField] private SOSkin Guardado;
    
    public void SetNickName()
    {
        PhotonNetwork.NickName = _InputplayerName.text;
        UIManager.instance.ActivateComponent(ComponentUI.MenuLobby);
        Guardado.name = _InputplayerName.text;
    }
    public TMP_Text GetNickName()
    {
        return _InputplayerName;
    }
}
