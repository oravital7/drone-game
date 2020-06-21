using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{   
    [SerializeField] int sceneToLoad;
    // Start is called before the first frame update
public void LoadScene()
{
    SceneManager.LoadScene(sceneToLoad);

}
}
