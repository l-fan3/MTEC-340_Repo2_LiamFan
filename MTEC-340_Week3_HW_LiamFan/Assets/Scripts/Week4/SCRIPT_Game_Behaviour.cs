using UnityEngine;
using TMPro;

public class GameBehaviour : MonoBehaviour
{
    public static GameBehaviour Instance;

    //public int _score = 0;
    public float InitBallSpeed = 5.0f;
    public float BallSpeedIncrement = 1.1f;
<<<<<<< HEAD
    private int _score;

    //public Player[] Players = new Player[2];

    //public int Score
    //{
    //    get { return _score; }
   //     set
   //     {
   //         _score = value;
   //         UpdateScoreUI();
   //     }
   // }

    [SerializeField] private TextMeshProUGUI _messages;
    [SerializeField] private TextMeshProUGUI _scoreTextUI;

=======
    public 
>>>>>>> parent of 65f1dee (Attempted to add UITextMesh (unsuccessful))
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

<<<<<<< HEAD
   // private void Start()
  //  {
   //     ResetGame();
  //  }

   // public void ScorePoint(int playerNumber)
  //  {
   //     Players[playerNumber - 1].Score += 1;
   //     CheckWinner();
  //  }

  //  private void CheckWinner()
  //  {
  //      foreach (Player p in Players)
  //      {
  //          if (p.Score >= _victoryScore)
  //          {
  //              ResetGame();
  //          }
  //      }
  //  }

 //   private void ResetGame();
 //   {
 //       foreach (Player p in Players)
 //       {
  //          p.Score = 0;
 //       }
  //  }
=======
    // Update is called once per frame
    void Update()
    {
        
    }
>>>>>>> parent of 65f1dee (Attempted to add UITextMesh (unsuccessful))
}


