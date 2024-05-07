using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterController : MonoBehaviour
{
    public Transform target; //the center object to be rotated around 
    public int speed;

    void Start()
    {
        if (target ==null)
        {
            target = this.gameObject.transform;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
