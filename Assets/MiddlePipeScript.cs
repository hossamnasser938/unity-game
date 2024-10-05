using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    private int birdLayer = 3;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == birdLayer) {
            logic.increaseScore(1);
        }
    }
}
