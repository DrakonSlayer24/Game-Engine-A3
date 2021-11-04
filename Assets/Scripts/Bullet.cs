using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody rb;
    Vector3 BulletSpeed = new Vector3(0, 0, 30);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + BulletSpeed * Time.deltaTime);
        if (rb.position.z < -50 || rb.position.z > 50)
        {
            gameObject.SetActive(false);
        }
    }
}
