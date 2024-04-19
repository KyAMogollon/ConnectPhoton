using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
     
    [SerializeField]
    private RoomListing _roomListing;



    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        DestroyAllRoom();

        foreach (RoomInfo info in roomList)
        {
            RoomListing listing = Instantiate(_roomListing,transform);
            if (listing != null)
                listing.SetRoomInfo(info);
        }
    }
    public void DestroyAllRoom()
    {
        Transform[] allChild = transform.GetComponentsInChildren<Transform>();
        foreach (var item in allChild)
        {
            Destroy(item.gameObject);
        }
    }
}
