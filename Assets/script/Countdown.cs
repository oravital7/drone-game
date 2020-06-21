using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField] int levelTolLoad;
    [SerializeField] float timer;
    [SerializeField] Text timerSeconds;
    // Start is called before the first frame update

    public bool isGameStarted = false;
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameStarted)
            return;

        timer -= Time.deltaTime;
        timerSeconds.text = "Time: "+timer.ToString("f2");
        if(timer<=0)
        {
          
            Application.LoadLevel(levelTolLoad);
        }
    }
}
