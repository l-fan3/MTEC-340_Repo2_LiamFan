using UnityEngine;
using TMPro;


public class SCRIPT_Player : MonoBehaviour
{
    private int _score;

    public class Player
    {
        
    }
    // int x = Score; 'runs the get function'
    // Score = 3; 'runs the set function'
    public int Score
    {
        //the get {} is the same as get => _score, however will need to use {} if it's more than 1 line
        get
        {
            return _score;
        }
        set 
        {
            _score = value;
            _scoreUI.text = Score.ToString();
        }
    }

    [SerializeField] private TextMeshProUGUI _scoreUI;

    private void Start()
    {
        Score = 100;
    }
}
