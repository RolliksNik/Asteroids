using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    bool pause = true;
    [SerializeField] Text _gameOver;
    // Start is called before the first frame update
    void Start()
    {
        _gameOver.enabled = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {

        if (pause == true)
        {
            Time.timeScale = 0;
            pause = false;
            
        }

        else
        {
            Time.timeScale = 1f;
            pause = true;
        }
    }

    public void StartNewGame()
    {
        Application.LoadLevel("SampleScene");
    }

    public void Close()
    {
        Application.LoadLevel("Menu");
    }
    public void CloseApp()
    {
        Application.Quit();
    }

    public void ActiveGameOver()
    {
        _gameOver.enabled = true;
    }
}
