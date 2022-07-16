using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //[Range(5f, 20f)] [SerializeField] private int _maxObjectCount;
    [Range(1f, 3f)] [SerializeField] private float _spawnDelay;
    private int _currentObjectCount;

    private GameManager _gameManager;

    public List<GameObject> _spawnableObjects = new List<GameObject>();

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        StartCoroutine(Spawn(_spawnDelay));
    }
    private void Update()
    {
       

    }

    IEnumerator Spawn(float delay)
    {
        if (_gameManager.CurrentObjectCount < _gameManager.MaxObjectCount)
        {
            yield return new WaitForSeconds(delay);
            int objectID = Random.Range(0, _spawnableObjects.Count);
            GameObject newObject = Instantiate(_spawnableObjects[objectID], new Vector3(Random.Range(-8f, 8f), transform.position.y, 0f), transform.rotation);
            _gameManager.CurrentObjectCount++;
        }
        StartCoroutine(Spawn(_spawnDelay));
    }
}
