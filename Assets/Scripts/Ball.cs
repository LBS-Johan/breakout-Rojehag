using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public int _timer;
    public float _speed;
    Rigidbody2D _rigidbody;
    public GameObject livesConsumer;

    public int maxHealth;

    [SerializeField]
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
       
        _rigidbody.velocity = new Vector2(0, 0);
        Invoke("StartMoving", _timer);

        currentHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
        

        if (transform.position.y <= -5)
        {
            
            transform.position = new Vector2(0, 0);
            _rigidbody.velocity = new Vector2(0, 0);
            
            currentHealth -= 1;

            Destroy(livesConsumer.transform.GetChild(currentHealth).gameObject);

            Invoke("StartMoving", _timer);


            
            if (currentHealth == 0)
            {
                GameOver();
            }


        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    void StartMoving()
    {
        _rigidbody.velocity = new Vector2(0, -2);
    }

   

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Ball")) return;


    }
}
