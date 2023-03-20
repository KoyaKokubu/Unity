using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            //Vector2.up : (0.1)
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 23 || transform.position.y < -23)
        {
            gameOver_birdDead();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver_birdDead();
    }

    private void gameOver_birdDead()
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
