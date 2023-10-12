using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BackToLobby : MonoBehaviourPunCallbacks
{

    public void LeaveGame()
    {
        PhotonNetwork.LoadLevel("Lobby");
        PhotonNetwork.LeaveRoom();
    }
    

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
}