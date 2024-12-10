using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    static int score;
   
    private void OnCollisionEnter2D(Collision2D _collision)
    {
        score += 1;

        Destroy(gameObject);
    }
}
