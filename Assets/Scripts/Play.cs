using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaY : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play() 
    {
        Score.playerScore = 0;

        SceneManager.LoadScene(scene);
    }
    public void exit()
    {
        Application.Quit();
    }
}
