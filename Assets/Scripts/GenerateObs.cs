using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject FallingObs;
    private float t = 0.0f;
    private float waitTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        recordTime();
       
    }

    void recordTime()
    {
        t += Time.deltaTime;
        if (t > waitTime)
        {
            ActivOb();
            t = t - waitTime;
        }
    }

    void ActivOb()
    {
            int x = Random.Range(-4, 11);
            int z = Random.Range(-4, 11);
            Vector3 newPosition = new Vector3(x, 12, z);
            GameObject newObj;
        newObj = Instantiate(FallingObs, newPosition, Quaternion.identity);
        }
    }

