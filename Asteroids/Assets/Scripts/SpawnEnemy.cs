using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyPrefab;
    private GameObject enemy;
    [SerializeField] private GameObject wall1;
    [SerializeField] private GameObject wall2;
    bool flag = true;
    Camera _cam;
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
         
    }

    // Update is called once per frame
    void Update()
    {
        
        if(flag == true)
        {
            flag = false;
            StartCoroutine(CreateEnemy());
            //enemy = Instantiate(enemyPrefab) as GameObject;
            //enemy.transform.position = new Vector2(Random.Range(-19,19),transform.position.y);
        }
    }

    private IEnumerator CreateEnemy()
    {
        int randNumber = Random.Range(0, enemyPrefab.Length);
        enemy = Instantiate(enemyPrefab[randNumber]);
        enemy.transform.position = new Vector2(Random.Range(wall1.transform.position.x + 1, wall2.transform.position.x - 1), transform.position.y);
        yield return new WaitForSeconds(1);
        flag = true;
    }
}
