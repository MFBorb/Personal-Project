using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DasherMovement : MonoBehaviour
{
    public float startDelay;
    public float repeatDelay;
    public float speed;
    public int numberOfDashes;

    private GameObject player;
    private Rigidbody dasherRb;
    // Start is called before the first frame update
    void Start()
    {
        dasherRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        InvokeRepeating("StartDashing", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDashing() {
        StartCoroutine(DashTowardsPlayer());
    }

    IEnumerator DashTowardsPlayer() {
        for (int i = 0; i < numberOfDashes; i++) {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            dasherRb.AddForce(lookDirection * speed);
            yield return new WaitForSeconds(0.9f);
            dasherRb.velocity = Vector3.zero;
            yield return new WaitForSeconds (0.1f);
        }
    }
}
