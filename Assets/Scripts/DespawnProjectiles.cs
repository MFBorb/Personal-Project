using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnProjectiles : MonoBehaviour
{
    void OnTriggerStay(Collider collider) {
        if (collider.gameObject.CompareTag("Geometry")) {
            Destroy(this.gameObject);
        }
    }
}
