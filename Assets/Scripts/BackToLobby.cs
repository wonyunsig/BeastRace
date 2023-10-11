using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class BackToLobby : MonoBehaviourPunCallbacks
{

    public void LeaveGame()
    {
        PhotonNetwork.Disconnect();
        PhotonNetwork.JoinLobby();
        SceneManager.LoadScene("Lobby");
    }
}