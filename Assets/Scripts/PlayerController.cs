using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable Instantiation

    // Public variables
    public float speed = 1.0f;

    // Private variables
    // The lab says to create horizontal/vertical input variables, but we don't
    // need them to be able to move our character. We can check the user's input
    // with GetKey without setting booleans.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() {

        // W/Up
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        // A/Left
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // S/Down
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        // D/Right
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
