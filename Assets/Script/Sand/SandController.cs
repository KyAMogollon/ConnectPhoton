using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class SandController : MonoBehaviourPunCallbacks
{
    #region Syngleton
    static SandController _instance;
    static public bool isActive
    {
        get
        {
            return _instance != null;
        }
    }
    static public SandController instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = UnityEngine.Object.FindObjectOfType(typeof(SandController)) as SandController;
                if (_instance == null)
                {
                    GameObject go = new GameObject("SandController");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<SandController>();
                }
            }
            return _instance;
        }
    }
    #endregion
    #region UI
    public TextMeshProUGUI UINickName;
    public GameObject PlayerGame;
    #endregion
    #region Room Info
    public List<Transform> spawnPointRoom = new List<Transform>();
    #endregion
    #region Player Info
    int myNumberInRoom;
    #endregion
    #region Gizmos
    [Range(0.2f, 1)]
    public float radiusSphereGizmos;
    #endregion
    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
        SceneManager.sceneLoaded += OnSceneFinishedLoading;
    }
    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
        SceneManager.sceneLoaded -= OnSceneFinishedLoading;
    }
    public Transform SpawnerPlayer()
    {
        int indexspawnPoint = UnityEngine.Random.Range(0, spawnPointRoom.Count - 1);
        indexspawnPoint = indexspawnPoint % spawnPointRoom.Count;
        Transform spawnTransform = spawnPointRoom[indexspawnPoint];
        return spawnTransform;
    }
    private void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        UINickName.text = "NickName: " + PhotonNetwork.NickName;
        PlayerGame = FactoryBuilder.instance.BuilderPlayer(PlayerInfo.instance.Selectedcharacter, PhotonNetwork.NickName, SpawnerPlayer());
        if (PlayerGame.GetComponent<PhotonView>().IsMine)
        {
            HealthPlayer _HealthPlayerSetup = PlayerGame.GetComponent<HealthPlayer>();
            if (_HealthPlayerSetup != null)
            {
                //_HealthPlayerSetup.HealthBarLocal = healthUI;     
            }
        }
    }
}
