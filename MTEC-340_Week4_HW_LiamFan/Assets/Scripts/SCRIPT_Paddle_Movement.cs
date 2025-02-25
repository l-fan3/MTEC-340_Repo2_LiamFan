using UnityEngine;

public class SCRPT_Movement : MonoBehaviour
{
    public float Speed = 7.5f;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public float xLimit = 8.0f;
    void Start()
    {
        
    }

    void Update()
    {
        //Start of loop will default to 0 at the start of the loop
        float movement = 0;
        
        //Detecting Key Inputs
        if (Input.GetKey(moveRight) && transform.position.x < xLimit)
        {
            movement += Speed;

        }
        if (Input.GetKey(moveLeft) && transform.position.x > -1 * xLimit)
        {
            movement -= Speed;
        }
        
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;
    }
}
