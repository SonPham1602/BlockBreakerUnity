using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 15f;
    
    private Vector2 paddleToBallVector;
    bool hasStarted = false;
    // Start is called before the first frame update
    void Start() 
    {
        paddleToBallVector = transform.position- paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasStarted == false)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
      
    }
    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
    private void LaunchOnMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
    }
}
