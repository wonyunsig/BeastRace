using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomItem : MonoBehaviour
{

  public TextMeshProUGUI roomName;
  private LobbyManager manager;

  private void Start()
  {
    manager = FindObjectOfType<LobbyManager>();
  }

  public void SetRoomName(string _roomName)
  {
    roomName.text = _roomName;
  }

  public void OnClickItem()
  {
    manager.JoinRoom(roomName.text);
  }

  public void JoinRoom(string roomName)
  {
    PhotonNetwork.JoinRoom(roomName);
  }
}
