using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddlePointCheck : MonoBehaviour
{
    public GameObject FinishLine;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FinishLine.SetActive(true);
        }
    }
}
