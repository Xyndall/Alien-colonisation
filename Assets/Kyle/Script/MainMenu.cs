using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class MainMenu : MonoBehaviour
{
    public Text scoretext;
    public PlayableDirector startcutscnce;

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
        startcutscnce.Play();

        StartCoroutine(WaitforCutscne());

    }

    public void PlaygameWin()
    {
        SceneManager.LoadScene(1);

    }

    private IEnumerator WaitforCutscne()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
