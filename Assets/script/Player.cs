using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidbody2D_Player;
    Vector2 startTouchPosition, endTouchPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D_Player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                rigidbody2D_Player.AddForce(Vector2.left * moveSpeed);
                //Debug.Log("code is executed");
            }
            else
            {
                rigidbody2D_Player.AddForce(Vector2.right * moveSpeed);
            }

        }
        else
        {
            rigidbody2D_Player.linearVelocity = Vector2.zero;
        }

        //if (Input.touchCount > 0) {

        //    Touch touch = Input.GetTouch(0);

        //    if (Input.GetMouseButtonDown(0))
        //    {

        //        startTouchPosition = Input.mousePosition;
        //    }
        //    else if (Input.GetMouseButtonUp(0)) {
        //        endTouchPosition = Input.mousePosition;
        //        Vector2 startWorldPosition = Camera.main.ScreenToWorldPoint(endTouchPosition);
        //        Vector2 startWorldPositio = Camera.main.ScreenToWorldPoint(startTouchPosition);

        //        Vector2 swipeDirection =  endTouchPosition - startTouchPosition;
        //        swipeDirection.Normalize();

        //        rigidbody2D_Player.linearVelocity = swipeDirection * moveSpeed;
        //    }

        //}


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("game");
        }

    }
}
