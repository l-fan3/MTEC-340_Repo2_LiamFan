using UnityEngine;
using TMPro;

public class GameBehaviour : MonoBehaviour
{
    public static GameBehaviour Instance;
    //public int _score = 0;
    public float InitBallSpeed = 5.0f;
    public float BallSpeedIncrement = 1.1f;
    public 
    void Awake()
    {
        // Singleton Pattern
        
        //when creating an instance, check if one already exists,
        //and if the existing is the one that is trying to be created
        if (Instance != null && Instance != this)
        {
            //if a different instance already exists,
            //please destroy the instance that is currently being created
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
