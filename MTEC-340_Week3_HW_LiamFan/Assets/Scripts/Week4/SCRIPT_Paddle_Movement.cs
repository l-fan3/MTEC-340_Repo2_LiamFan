using UnityEngine;

public class SCRPT_Movement : MonoBehaviour
{
    public float Speed = 5.0f;
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float yLimit = 4.25f;
    void Start()
    {
        
    }

    void Update()
    {
        //Start of loop will default to 0 at the start of the loop
        float movement = 0;
        
        //Detecting Key Inputs
        if (Input.GetKey(moveUp) && transform.position.y < yLimit)
        {
            movement += Speed;

        }
        if (Input.GetKey(moveDown) && transform.position.y > -1 * yLimit)
        {
            movement -= Speed;
        }
        
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime;
    }
}
