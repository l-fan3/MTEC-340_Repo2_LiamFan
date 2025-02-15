using System;
using System.Collections;
using UnityEngine;
using TMPro;


public class GameBehaviour : MonoBehaviour

{
    public static GameBehaviour Instance;
    //public int _score = 0;
    public float InitBallSpeed = 5.0f;
    public float BallSpeedIncrement = 1.1f;
    private int _score;

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            UpdateScoreUI();
        }
    }
    
    [SerializeField] private TextMeshProUGUI _messages;
    [SerializeField] private TextMeshProUGUI _scoreTextUI;

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

    private void Start()
    {
        Score = 0;
        _messages.enabled = false;
    }
    //chat GPT>
    private void UpdateScoreUI()
    {
        if (_scoreTextUI != null)
        {
            _scoreTextUI.text = "Score: " + _score.ToString(); // Update UI text
        }
        else
        {
            Debug.LogWarning("Score UI is not assigned in the inspector.");
        }
    }

    public void AddScore(int amount)
    {
        Score += amount;
    }
}
