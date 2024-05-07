using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject FallingObs;
    public float timer = 0.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        FallingObs = GameObject.FindWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {
        recordTime();
        if (timer>3.0f)
        {

                ActObj();
            timer = 0.0f;
        }
    }

        void ActObj()
    {
        int x = Random.Range(-4, 11);
        int z = Random.Range(-4, 11);
        Vector3 newPosition = new Vector3(x, 12, z);
        FallingObs.transform.position = newPosition;
        FallingObs.gameObject.SetActive(true);
    }

    void recordTime()
    {
        timer += Time.deltaTime;
    }

}

