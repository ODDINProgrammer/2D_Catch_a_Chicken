using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Range(1f, 3f)] [SerializeField] private float _spawnDelay;
    [SerializeField] private int _objectSpawnAmount;

    private GameManager _gameManager;


    [SerializeField] private List<float> _chanceToSpawn;
    private float _totalChance;
    [SerializeField] private List<GameObject> _spawnableObjects;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();

        for (int i = 0; i < _chanceToSpawn.Count; i++)
        {
            _totalChance += _chanceToSpawn[i];
        }

        StartCoroutine(Spawn(_spawnDelay));

    }

    IEnumerator Spawn(float delay)
    {
        yield return new WaitForSeconds(delay);
        for (int i = 0; i < _objectSpawnAmount; i++)
        {
            if (_gameManager.CurrentObjectCount < _gameManager.MaxObjectCount)
            {
                SpawnObject();
            }
        }
        StartCoroutine(Spawn(_spawnDelay));
    }

    private int FindObjectID()
    {
        float random = Random.Range(0f, 1f);
        float numForAdding = 0f;
        int objectID = 0;
        for (int j = 0; j < _chanceToSpawn.Count; j++)
        {
            if (_chanceToSpawn[j] / _totalChance + numForAdding >= random) { objectID = j; break; }
            else { numForAdding += _chanceToSpawn[j] / _totalChance; }
        }
        return objectID;
    }

    private void SpawnObject()
    {
        GameObject newObject = Instantiate(_spawnableObjects[FindObjectID()], new Vector3(Random.Range(-8f, 8f), transform.position.y, 0f), transform.rotation);
        _gameManager.CurrentObjectCount++;
    }
}
