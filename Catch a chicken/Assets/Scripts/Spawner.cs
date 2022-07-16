using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Range(5f, 20f)] [SerializeField] private int _maxObjectCount;
    [Range(1f, 3f)] [SerializeField] private float _spawnDelay;
    private int _currentObjectCount;

    public List<GameObject> _spawnableObjects = new List<GameObject>();

    private void Update()
    {
        if (_currentObjectCount < _maxObjectCount)
        {
            int objectID = Random.Range(0, _spawnableObjects.Count);
            GameObject newObject = Instantiate(_spawnableObjects[objectID], new Vector3(Random.Range(-8f, 8f), transform.position.y, 0f), transform.rotation);
            _currentObjectCount++;
        }

    }

    //IEnumerator Spawn(float delay)
    //{
    //    int objectID = Random.Range(0, _spawnableObjects.Count);
    //    GameObject newObject = Instantiate(_spawnableObjects[objectID], new Vector3(Random.Range(-8f, 8f), 0f, 0f), transform.rotation);
    //    _currentObjectCount++;
    //    yield return new WaitForSeconds(delay);

    //}

    //private void Spawn()
    //{
    //    //yield return new WaitForSeconds(delay);

    //    float xPos = Random.Range(-8f, 8f);
    //    Vector2 spawnPos = new Vector2(xPos, transform.position.y);

    //    int objectID = Random.Range(0, _spawnableObjects.Count);
    //    Instantiate(_spawnableObjects[objectID], spawnPos, Quaternion.identity, this.transform);

    //    _currentObjectCount++;
    //}
}
