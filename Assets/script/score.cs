using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{   

    Rigidbody drone;
    [SerializeField] Text scoreT;
    [SerializeField] int scorePlanetPrurple;

    [SerializeField] int scorePlanetBlue;

    [SerializeField] int scorePlanetYellow;

    [SerializeField] int scorePlanetRed;

    public static int  scorep=0;
    // Start is called before the first frame update
 void OnCollisionEnter(Collision collisionInfo)
{
    if(collisionInfo.gameObject.tag=="blueP")
    {   
        scorep+=scorePlanetBlue;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+scorep;
    }
     if(collisionInfo.gameObject.tag=="redP")
    {   
        scorep+=scorePlanetRed;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+scorep;
    }
     if(collisionInfo.gameObject.tag=="yellowP")
    {   
        scorep+=scorePlanetYellow;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+scorep;
    }
     if(collisionInfo.gameObject.tag=="purpleP")
    {   
        scorep+=scorePlanetPrurple;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+scorep;
    }


         }
}


