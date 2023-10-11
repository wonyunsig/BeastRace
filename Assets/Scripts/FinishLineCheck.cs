using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class FinishLineCheck : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject LosePanel;

    public void OnTriggerEnter(Collider other)
    {
        DinoController dinoController = other.GetComponent<DinoController>();

        if (dinoController != null && dinoController.view.IsMine && CompareTag("Player"))
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