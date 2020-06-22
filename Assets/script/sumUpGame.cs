using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sumUpGame : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] Text scoreT;


    // Update is called once per frame
    void Start()
    {
        if (score.scorep > score.scoreOther)
            scoreT.text = "You Win!!! with score: " + score.scorep;
        else if(score.scoreOther>score.scorep)
            scoreT.text = "You Loose :( with score: " + score.scorep;
        else
            scoreT.text = "It's a draw with score: " + score.scorep;

    }
}
