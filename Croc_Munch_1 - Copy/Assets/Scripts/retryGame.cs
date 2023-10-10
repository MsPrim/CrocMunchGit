using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LoadGame()
    {
        //This will load "SampleScene" after the player clicks the restart button
        SceneManager.LoadSceneAsync("GameOverScreen");

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
