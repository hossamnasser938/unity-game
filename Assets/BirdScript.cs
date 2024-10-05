using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public int movingUpPower;
    private bool isBirdAlive = true;
    public LogicScript logic;
    private int upperDeadZone = 25, lowerDeadZone = -25;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive) {
            moveUp();
        }

        Debug.Log("y = " + transform.position.y);
        if (transform.position.y > upperDeadZone|| transform.position.y < lowerDeadZone) {
            GameOver();
        }
    }

    void moveUp() {
        myRigidBody.velocity = Vector2.up * movingUpPower;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        GameOver();
    }

    private void GameOver() {
        isBirdAlive = false;
        logic.ShowGameOverUI();
    }
}
