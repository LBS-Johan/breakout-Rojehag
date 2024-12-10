using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int _timer;
    public float _speed;
    Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
       
        _rigidbody.velocity = new Vector2(0, -2);
        Invoke("StartMoving", _timer);
        
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
        

        if (transform.position.y <= -5)
        {
            
            transform.position = new Vector2(0, 0);
            _rigidbody.velocity = new Vector2(0, 0);
            Invoke("StartMoving", _timer);

        }
    }

    void StartMoving()
    {
        _rigidbody.velocity = new Vector2(0, -2);
    }
}
