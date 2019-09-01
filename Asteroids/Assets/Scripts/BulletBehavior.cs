using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    [SerializeField] float speed;
    int direction = 0;
    GameObject _manager;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        _manager = GameObject.Find("Manager");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == 1)
        {
            rb.MovePosition(transform.position + (Vector3.up * speed));
        }

        else
        {
            rb.MovePosition(transform.position + (Vector3.down * speed));
            //transform.Translate(Vector3.down * 0.1f);
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<PlayerManager>() != null)
        {
            collision.GetComponentInParent<PlayerManager>().ChangeHealth(1);
            Destroy(this.gameObject);
        }

        if (direction == 1 && collision.GetComponent<Trig>() == null && collision.GetComponent<BulletBehavior>() == null)
        {
             collision.GetComponent<Strength>().SetStrength();
            _manager.GetComponent<Points>().SetPoints();
            Destroy(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }

        

    }

    public void SetDirection(int direction)
    {
        this.direction = direction;
    }

}
