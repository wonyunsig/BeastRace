using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
