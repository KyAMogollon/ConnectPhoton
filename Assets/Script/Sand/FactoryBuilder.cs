using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.IO;

public class FactoryBuilder : MonoBehaviour
{
    #region Syngleton
    static FactoryBuilder _instance;
    static public bool isActive
    {
        get
        {
            return _instance != null;
        }
    }
    static public FactoryBuilder instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = UnityEngine.Object.FindObjectOfType(typeof(FactoryBuilder)) as FactoryBuilder;
                if (_instance == null)
                {
                    GameObject go = new GameObject("FactoryBuilder");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<FactoryBuilder>();
                }
            }
            return _instance;
        }
    }
    #endregion
    void Start()
    {

    }
    public GameObject BuilderPlayer(string prefabnameSand, string nickname, Transform spawnTransform)
    {
        GameObject player = null;
        player = PhotonNetwork.Instantiate(Path.Combine("Prefabs/Characters", prefabnameSand), spawnTransform.position, spawnTransform.rotation, 0);
        if (player != null)
        {
            PlayerSetUp _PlayerSetup = player.GetComponent<PlayerSetUp>();
            player.GetComponent<PhotonView>().Controller.NickName = nickname;
        }
        return player;
    }
}
