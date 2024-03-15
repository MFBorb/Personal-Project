using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableMovement : MonoBehaviour
{
    public float secondsForFullRotation = 3.0f;
    private Vector3 basePosition;
    private float sinInput = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        sinInput += Time.deltaTime;
        transform.position = new Vector3(basePosition.x, basePosition.y + (Mathf.Sin(sinInput) * 0.25f));
        transform.Rotate(0, 360.0f / secondsForFullRotation * Time.deltaTime, 0);
    }
}
