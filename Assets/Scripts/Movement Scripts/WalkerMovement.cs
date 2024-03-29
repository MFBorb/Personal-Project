using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerMovement : MonoBehaviour
{
    public float speed = 3.0f;
    private GameObject player;
    private Rigidbody walkerRb;
    // Start is called before the first frame update
    void Start()
    {
        walkerRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        walkerRb.AddForce(lookDirection * speed * Time.deltaTime);
    }
}
