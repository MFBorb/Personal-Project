using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision) {
        if (collision.gameObject.CompareTag("Enemy")) {
            float damageValue = collision.gameObject.GetComponent<EnemyDamage>().damageAmount * Time.deltaTime;
            Debug.Log("Player took " + damageValue + " damage from " + collision.gameObject.name);
        }
    }

    void OnTriggerStay(Collider collider) {
        if (collider.gameObject.CompareTag("Health")) {
            float healthValue = collider.gameObject.GetComponent<ConsumableHeal>().healAmount;
            Debug.Log("Player gained " + healthValue + " health from " + collider.gameObject.name);
            Destroy(collider.gameObject);
        }
        else if (collider.gameObject.CompareTag("EnemyProjectile")) {
            float damageValue = collider.gameObject.GetComponent<EnemyDamage>().damageAmount;
            Debug.Log("Player took " + damageValue + " damage from " + collider.gameObject.name);
            Destroy(collider.gameObject);
        }
    }
}
