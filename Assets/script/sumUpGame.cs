using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sumUpGame : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] Text scoreT;


    // Update is called once per frame
    void Update()
    {   
  
     
        scoreT.text="Youer score : "+score.scorep;
        
    }
}
