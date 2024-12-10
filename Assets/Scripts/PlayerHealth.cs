using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int maxHealth;

    [SerializeField]
    public int currentHealth = 3; 


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            currentHealth -= 1;
        }
        if (currentHealth == 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
