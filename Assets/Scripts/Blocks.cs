using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D _collision)
    {
        Destroy(gameObject);
    }
}
