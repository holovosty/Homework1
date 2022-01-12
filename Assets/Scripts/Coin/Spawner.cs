using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _templatePrefab;
    [SerializeField] private Transform _spawnLocation;

    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[_spawnLocation.childCount];

        for (int i = 0; i < _spawnLocation.childCount; i++)
        {
            _spawnPoints[i] = _spawnLocation.GetChild(i);
        }

        Spawn();
    }

    private void Spawn()
    {
        int currentPoint = 0;

        while (currentPoint != _spawnPoints.Length)
        {
            Transform instantiatePosition = _spawnPoints[currentPoint];
            GameObject newItem = Instantiate(_templatePrefab, instantiatePosition.position, Quaternion.identity);

            if (currentPoint < _spawnPoints.Length)
            {
                currentPoint++;
            }
        }
    }
}
