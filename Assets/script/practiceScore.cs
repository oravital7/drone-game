using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class practiceScore : MonoBehaviour
{

    Rigidbody drone;

    [SerializeField] int scorePlanetPrurple;

    [SerializeField] int scorePlanetBlue;

    [SerializeField] int scorePlanetYellow;

    [SerializeField] int scorePlanetRed;

    public static int scorep = 0;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "blueP")
        {
           
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "redP")
        {
            
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "yellowP")
        {
            
            Destroy(collisionInfo.gameObject);
        }
        if (collisionInfo.gameObject.tag == "purpleP")
        {
            
            Destroy(collisionInfo.gameObject);
        }

       


    }
}




