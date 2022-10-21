using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Darling _darling;
    public GameObject Gokces;
    public float height;
    public float time;

    void Start()
    {
        _ = StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!_darling.isDead)
        {
            Instantiate(Gokces, new Vector3(1.5f, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
