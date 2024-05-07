using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public int count;


    private void Start()
    {
        count = 0;
    }

    void FixedUpdate()
    {
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horAxis, 0.0f, verAxis);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectible")
        {
            count++;
            other.gameObject.SetActive(false);

        }
    }
}