using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float countdown = 3f;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        float time = Mathf.CeilToInt(countdown);
        text.text = time.ToString("F0");
        if (countdown <= 0)
        {
            text.text = "GO!";
            DinoController.start = 1;
            Invoke("DestroyPanel", 0.5f);
        }
    }

    private void DestroyPanel()
    {
        gameObject.SetActive(false);
    }
}
