using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D _myrigidbody;
    [SerializeField]
    GameObject Ball; 

    public int _speed;
    // Start is called before the first frame update
    void Start()
    {
        _myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _myrigidbody.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            _myrigidbody.velocity = new Vector2(-1, 0) * _speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            _myrigidbody.velocity = new Vector2(1, 0) * _speed;
        }
        if (Ball.transform.position.y <= -5)
        {
            transform.position = new Vector2(0, -4);
        }
    }
}
