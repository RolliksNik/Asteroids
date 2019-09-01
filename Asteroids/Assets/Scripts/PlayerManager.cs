using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    int health = 10;
    [SerializeField] Text _text;
    GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = "Прочность: " + health;
        
    }

    public void ChangeHealth(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
           Time.timeScale = 0;
           controller = GameObject.Find("HUDCanvas");
           controller.GetComponent<Controller>().ActiveGameOver();
            
        }
    }
}
