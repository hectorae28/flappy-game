using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public gameScreenManagerScript gameScreenManager;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }
    private void Jump(){
        Rigidbody2D.velocity=Vector2.up * JumpForce;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        gameScreenManager.GameOver();
    }
}
