using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;
    public float interval;

    [SerializeField]
    private float swarmerInterval = 3.5f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval*Time.deltaTime, swarmerPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float inverval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
