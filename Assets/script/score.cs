using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class score : NetworkBehaviour
{

    Rigidbody drone;
    [SerializeField] Text scoreT;

    [SerializeField] int scorePlanetPrurple;

    [SerializeField] int scorePlanetBlue;

    [SerializeField] int scorePlanetYellow;

    [SerializeField] int scorePlanetRed;

    public static int scorep = 0;
    public static int scoreOther = 0;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        scoreT = canvas.GetComponentsInChildren<Text>()[1];
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        int currentScore = 0;

        Debug.Log("OnCollision");
        if (collisionInfo.gameObject.tag == "blueP")
        {
            currentScore += scorePlanetBlue;
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "redP")
        {
            currentScore += scorePlanetRed;
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "yellowP")
        {
            currentScore += scorePlanetYellow;
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "purpleP")
        {
            currentScore += scorePlanetPrurple;
            Destroy(collisionInfo.gameObject);
        }

        if (isLocalPlayer)
        {
            scorep += currentScore;
            scoreT.text = "Score: " + scorep;

        }
        else
        {
            scoreOther += currentScore;
            scoreT.text = "Score: " + scorep;
        }


    }
}


