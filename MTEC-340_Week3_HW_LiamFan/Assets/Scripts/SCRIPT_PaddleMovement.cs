using UnityEngine;

public class SCRIPT_PaddleMovement : MonoBehaviour
{
    public float paddleSpeed = 10.0f;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float xLimit = 8.55f;
    void Start()
    {
        
    }

    void Update()
    {
        float movement = 0f;

        if (Input.GetKey(moveRight) && transform.position.x < xLimit)
        {
            movement += paddleSpeed;
        }

        if (Input.GetKey(moveLeft) && transform.position.x > -xLimit)
        {
            movement -= paddleSpeed;
        }
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;
    }
}
