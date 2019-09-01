using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;
    float horizontalMove = 0;
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
        horizontalMove = Input.GetAxis("Horizontal") * speed ;
        rb.MovePosition(transform.position + new Vector3(horizontalMove, 0, 0));
    }


    

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    public void SetSpeed(int val)
    {
        speed = val;
    }


}
