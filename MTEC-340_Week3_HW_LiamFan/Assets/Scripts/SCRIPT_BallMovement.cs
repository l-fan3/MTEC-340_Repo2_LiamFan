using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SCRIPT_BallMovement : MonoBehaviour
{
    public float xSpeed = 8.0f;
    public float ySpeed = 8.0f;
    public float xLimit = 9.3f;
    public float yLimit = 4.6f;
    private int _xDirection;
    private int _yDirection;

    //paddle scale
    public float paddleScaleX = 2.0f;
    private float paddleOffsetX;
    public float paddleScaleY = 0.25f;
    private float paddleOffsetY;
    
    //paddle object reference
    public GameObject Paddle;

    //ball scale
    public float ballScaleXY = 0.5f;
    private float ballOffsetX;
    private float ballOffsetY;
    
    //offset
    private float totalOffsetY;
    private float totalOffsetX;
    
    
    void Start()
    {
    //Setting up random direction on Start
      _xDirection = Random.value > 0.5f ? 1 : -1;
      _yDirection = Random.value > 0.5f ? 1 : -1;
      
      //calculating offset of the paddle position from bottom left
      paddleOffsetX = (paddleScaleX * 0.5f);
      paddleOffsetY = (paddleScaleY * 0.5f); 
      //Debug.Log(paddleOffsetX);
      //Debug.Log(paddleOffsetY);
    }

    void Update()
    {
        //clamp suggestion from chatgpt - I noticed that sometimes the ball would get stuck and go out of bounds.
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -xLimit, xLimit),
            Mathf.Clamp(transform.position.y, -yLimit, yLimit),
            transform.position.z
        );

        
        Vector3 paddlePosition = Paddle.transform.position;
        //Debug.Log("Paddle Position - X: " + (paddlePosition.x - paddleOffsetX) + ", Y: " + (paddlePosition.y - paddleOffsetY));

        // boundary X
        if (Mathf.Abs(transform.position.x) >= xLimit)
        {
            _xDirection *= -1;
        }

        // boundary Y
        if (Mathf.Abs(transform.position.y) >= yLimit)
        {
            _yDirection *= -1;
        }

        // paddle collision 
        if ((transform.position.y >= -0.25f && transform.position.y <= 0.25f) && (transform.position.x >= paddlePosition.x - paddleOffsetX) && (transform.position.x <= paddlePosition.x + paddleScaleX))
        {
            _yDirection *= -1;
        }
        
        transform.position += new Vector3((xSpeed * _xDirection), (ySpeed * _yDirection), 0) * Time.deltaTime;
    }
}
