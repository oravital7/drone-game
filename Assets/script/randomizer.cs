using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizer : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    private float x;
    private float y;
    private float z;
    float nextSp = 0.0f;
    [SerializeField] float rate = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSp)
        {
            nextSp = Time.time + rate;
            x = (Random.Range(-50.0f, 50.0f));
            y = (Random.Range(-50.0f, 50.0f));
            z = (Random.Range(-50.0f, 50.0f));
            Instantiate(gameObject, new Vector3(x, y, z), Quaternion.identity);
        }
        
    }
}
