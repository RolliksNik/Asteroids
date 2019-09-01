using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : MonoBehaviour
{
    enum Protection : int
    {
        Gun = 1,
        Protection1 = 2,
        Body = 2,
        Asteroid1 = 2,
        Asteroid2 = 3,
        Asteroid3 = 4

    }

    int _strength = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "GUN")
        {
            _strength = (int)Protection.Gun;
        }

        else if (gameObject.name == "Protection1")
        {
            _strength = (int)Protection.Protection1;
        }

        else if(gameObject.name == "Asteroid1")
        {
            _strength = (int)Protection.Asteroid1;
        }

        else if (gameObject.name == "Asteroid2")
        {
            _strength = (int)Protection.Asteroid2;
        }

        else if (gameObject.name == "Asteroid3")
        {
            _strength = (int)Protection.Asteroid3;
        }

        else
        {
            _strength = (int)Protection.Body;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetStrength()
    {
        _strength -= 1;
        if (_strength == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public int GetStrength()
    {
        return _strength;
    }
}


