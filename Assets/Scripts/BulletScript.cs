using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private float speedMod = -20f;
    //public Transform target;

    private void Start()
    {
        //Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);

        speed += speedMod * Time.deltaTime;
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.y > 10)
        {
            //Destroy(gameObject);
        }

    }
}
