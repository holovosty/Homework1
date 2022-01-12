using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _templatePrefab;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _instantiantePoints;



    private void Start()
    {
        _instantiantePoints = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _instantiantePoints[i] = _spawnPoints.GetChild(i);
        }

        Instantiate();
    }

    private void Instantiate()
    {
        int currentPoint = 0;

        while (currentPoint != _instantiantePoints.Length)
        {
            Transform instantiatePosition = _instantiantePoints[currentPoint];
            GameObject newItem = Instantiate(_templatePrefab, instantiatePosition.position, Quaternion.identity);

            if (currentPoint < _instantiantePoints.Length)
            {
                currentPoint++;
            }
        }
    }
}
