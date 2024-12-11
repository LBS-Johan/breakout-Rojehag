using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Blocks : MonoBehaviour
{
    
    static int score;
    [SerializeField]
    public static TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        scoreText = GameObject.Find()
    }

    private void OnCollisionEnter2D(Collision2D _collision)
    {
        score += 1;
        scoreText.text = "Score: " + score;

        Destroy(gameObject);
    }
}
