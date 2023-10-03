using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;
    public Transform spawner;

    public GameObject[] bullets;

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
        Reload(); // figure out how to do this -- remember to ask Jeff
    }

    void Move()
    {
        Vector3 inputVector = new Vector3(
            Input.GetAxisRaw("Horizontal"),    // x axis
            Input.GetAxisRaw("Vertical"),      // y axis
            0.0f                            // z axis
            );

        transform.Translate(inputVector.normalized * speed * Time.deltaTime);

        // OLD MOVEMENT
        //transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        //transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }

    void Reload()
    {


    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int whichBullet = Random.Range(0, bullets.Length);
            Instantiate(bullets[whichBullet], spawner.position,
                bullets[whichBullet].transform.rotation);
            Debug.Log("Firing " + bullets[whichBullet]);
        }
    }
}
