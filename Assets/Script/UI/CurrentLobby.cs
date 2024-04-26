using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class CurrentLobby : MonoBehaviour
{
    public TMP_Text sala;
    public TMP_Text nickname;
    [SerializeField] CreateRoomMenu roomMenu;
    [SerializeField] CreatePlayerMenu playerMenu;
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
        sala.text = "RoomName: " + roomMenu.GetNameRoom().text;
        nickname.text="NickName: " + playerMenu.GetNickName().text;
    }
}
