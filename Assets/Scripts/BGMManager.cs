using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    public int targetSceneIndex;
    public AudioSource audioSource;
    
    void Awake ()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        var objs = FindObjectsOfType<BGMManager>();
        if (objs.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (currentSceneIndex == targetSceneIndex)
        {
            audioSource.Stop();
        }
    }

}
