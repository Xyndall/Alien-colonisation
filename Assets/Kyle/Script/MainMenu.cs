using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "200";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Playgame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
