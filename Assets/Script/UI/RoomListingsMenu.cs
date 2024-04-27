using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] Transform _content;
    [SerializeField] RoomListing _roomListing;

    private List<RoomListing> _listings = new List<RoomListing>();
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        print("se actualizo la lista de salas");
        foreach (RoomInfo info in roomList)
        {

            if (info.RemovedFromList)
            {
                int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                if (index != -1)
                {
                    Destroy(_listings[index].gameObject);
                    _listings.RemoveAt(index);
                }
            }

            else
            {
                RoomListing listing = Instantiate(_roomListing, _content);
                if (listing != null)
                {
                    listing.SetRoomInfo(info);
                }
            }
        }
    }

}


//public class RoomListingsMenu : MonoBehaviourPunCallbacks
//{

//    [SerializeField]
//    private RoomListing _roomListing;



//    public override void OnRoomListUpdate(List<RoomInfo> roomList)
//    {
//        DestroyAllRoom();

//        foreach (RoomInfo info in roomList)
//        {
//            RoomListing listing = Instantiate(_roomListing, transform);
//            if (listing != null)
//                listing.SetRoomInfo(info);
//        }
//    }
//    public void DestroyAllRoom()
//    {
//        Transform[] allChild = transform.GetComponentsInChildren<Transform>();
//        foreach (var item in allChild)
//        {
//            Destroy(item.gameObject);
//        }
//    }
//}
