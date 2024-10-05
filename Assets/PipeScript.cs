using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float movementSpeed = 5;
    int deadZone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();

        CheckToDestroy();
    }

    void UpdatePosition( ) {
        transform.position = transform.position + (Vector3.left * movementSpeed) * Time.deltaTime;
    }

    void CheckToDestroy() {
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
