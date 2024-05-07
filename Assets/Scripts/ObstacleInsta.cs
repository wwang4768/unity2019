using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInsta : MonoBehaviour
{
    public GameObject Obstacle;
    private float timer = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * 1 * Time.deltaTime/10);

       /* if (transform.position.y < 1)
        {
            Obstacle.gameObject.SetActive(false);
        }
        */
        timer += Time.deltaTime;
        Debug.Log(timer);

        if (timer > 4.0f)
        {
            ActObj();
            transform.Translate(Vector3.down * 1 * Time.deltaTime / 10);
            timer = 0.0f;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }

    void ActObj()
    {
        int x = Random.Range(-4, 11);
        int z = Random.Range(-4, 11);
        Vector3 newPosition = new Vector3(x, 7, z);
        Obstacle.transform.position = newPosition;

        Obstacle.gameObject.SetActive(true);

    }
}
