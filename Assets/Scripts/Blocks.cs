using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocks : MonoBehaviour
{
    
    

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D _collision)
    {
       

        Destroy(gameObject);
    }
}
