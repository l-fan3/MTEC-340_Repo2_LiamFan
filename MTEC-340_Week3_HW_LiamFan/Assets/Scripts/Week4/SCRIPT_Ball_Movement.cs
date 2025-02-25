using Unity.Mathematics.Geometry;
using UnityEngine;

public class SCRPT_Ball_Movement : MonoBehaviour
{
    public float _speed = 5.0f;
    public float yLimit = 4.6f;
    public float xLimit = 9.4f;
    private int _xDirection;
    private int _yDirection;
    private int _score;
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _SFXwallHit;
    [SerializeField] private AudioClip _SFXpaddleHit;
    [SerializeField] private AudioClip _SFXscore;
    [SerializeField] private AudioClip _SFXgameOver;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        ResetBall();
    }

    void Update()
    {
        //y positive limit bounce
        if (transform.position.y >= yLimit)
        {
            //fixing the ball getting stuck 
            transform.position = new Vector3(
                transform.position.x,
                Mathf.Sign(transform.position.y) * yLimit,
                transform.position.z);
            _yDirection *= -1;
            //_source.clip = _wallHit;
            //_source.Play();
        }

        //y negative limit reset
        if (transform.position.y <= -yLimit)
        {
         //   GameBehaviour.Instance.ScorePoint(transform.position.x >  0 ? 1 : 2);
            ResetBall();
            Debug.Log("Game Over!");
            _audioSource.PlayOneShot(_SFXgameOver);
        }
            
        //x limit bounce
        if (Mathf.Abs(transform.position.x) >= xLimit)
        {
            //_source.clip = _score;
            //_source.Play();
            transform.position = new Vector3(
                Mathf.Sign(transform.position.x) * xLimit,
                transform.position.y,
                transform.position.z);
            
            _xDirection *= -1;
        }
        transform.position += new Vector3((_speed * _xDirection), (_speed * _yDirection), 0) * Time.deltaTime;
    }

    void ResetBall()
    {
        //format for accessing: CLASSNAME.Instance.VARIABLENAME;
        //_speed = GameBehaviour.Instance.InitBallSpeed;
        //setting x, y and z values to 0
        _speed = 5.0f;
        transform.position = Vector3.zero;
        //choosing the random direction again
        _yDirection = Random.value > 0.5 ? 1 : -1;
        _xDirection = Random.value > 0.5 ? 1 : -1;

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Paddle"))
        {
            //_source.clip = _paddleHit;
           // _source.Play();
            _yDirection *= -1;
            Debug.Log("Paddle Hit!");
            //_speed *= GameBehaviour.Instance.BallSpeedIncrement;
        }

        if (other.gameObject.CompareTag("Brick"))
        {
            _yDirection *= -1;
            Destroy(other.gameObject);
            _score += 1;
            Debug.Log("Score: " + _score);
            _audioSource.PlayOneShot(_SFXscore);


        }
      
    }
}
