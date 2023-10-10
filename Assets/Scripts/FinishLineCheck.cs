using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FinishLineCheck : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject LosePanel;
    private PhotonView view;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (view.IsMine)
            {
                WinPanel.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                LosePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
