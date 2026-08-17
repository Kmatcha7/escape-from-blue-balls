using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeManager : MonoBehaviour
{
    public float timeLimit = 60.0f;
    public Text timerText;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("f1");
        }
        else
        {
            timerText.text = "GAMECLEAR";
            SceneManager.LoadScene("gameclear");

        }
    }
}
