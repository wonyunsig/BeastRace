using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class BackToLobby : MonoBehaviourPunCallbacks
{

    public void LeaveGame()
    {
        if (PhotonNetwork.NetworkClientState != ClientState.Leaving)
        {
            Time.timeScale = 1f;
            PhotonNetwork.LeaveRoom();
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
}