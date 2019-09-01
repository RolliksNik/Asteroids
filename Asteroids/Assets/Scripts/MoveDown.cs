using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField] float speed = 0.05f;
    Rigidbody2D rb;
    GameObject _player;
    [SerializeField] int collisionDamage;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(transform.position + (Vector3.down * speed));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInParent<PlayerManager>() != null )
        {
            //_manager.GetComponent<Points>().SetPoints();
            _player.GetComponent<PlayerManager>().ChangeHealth(collisionDamage);
            Destroy(this.gameObject);

        }
    }
}
