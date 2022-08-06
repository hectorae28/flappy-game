using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public gameScreenManagerScript gameScreenManager;
    public float JumpForce;
    private Animator Animator;
    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D=GetComponent<Rigidbody2D>();
        Animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)|Input.touchCount>0){
            Animator.SetBool("Jumping",true);
            Jump();
        }else if (Input.touchCount==0)Animator.SetBool("Jumping",false);
    }
    private void Jump(){
        Rigidbody2D.velocity=Vector2.up * JumpForce;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        gameScreenManager.GameOver();
    }
}
