using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] int collisionDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponentInParent<PlayerManager>() != null)
        {
            collision.GetComponentInParent<PlayerManager>().ChangeHealth(collisionDamage);
            Destroy(this.gameObject);
        }

        else if(collision.GetComponent<Trig>() == null)
        {
            Destroy(collision.gameObject);
        }
    }
}
