using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    bool flag = true;
    [SerializeField] GameObject prefabBullet;
    [SerializeField] Material _material;
    private GameObject bullet;
    Vector2 vec;
    int direction = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            flag = false;
            if(GetComponentInParent<PlayerManager>() != null)
            {
                vec = Vector2.up * 3.5f;
                direction = 1;
            }

            else
            {
                vec = Vector2.down * 2.5f;
                direction = -1;
            }
            StartCoroutine(CreateBullet(vec,direction));
        }
    }

    private IEnumerator CreateBullet(Vector2 vec, int direction)
    {
        bullet = Instantiate(prefabBullet) as GameObject;
        bullet.GetComponent<MeshRenderer>().material = _material;
        bullet.transform.position = transform.TransformPoint(vec);
        bullet.GetComponent<BulletBehavior>().SetDirection(direction);

        yield return new WaitForSeconds(2);
        flag = true;
        
    }
}
