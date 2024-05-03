using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerSetUp : MonoBehaviour
{

    public PhotonView PV { get; set; }
    public Transform _ui;
    public TextMeshProUGUI Localnickname;
    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
        if (!PV.IsMine)
        {
            SetLocalNickName(PV.Controller.NickName);
            CapsuleCollider collider = this.gameObject.AddComponent<CapsuleCollider>();
            Destroy(GetComponent<Rigidbody>());
        }
        else
        {
            GameObject Camera = GameObject.FindGameObjectWithTag("MainCamera");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetLocalNickName(string name)
    {
        if (Localnickname != null)
            Localnickname.text = name;
    }
}
