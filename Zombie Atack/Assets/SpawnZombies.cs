using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform[] _positionSpawn;
    [SerializeField]private int _countWave;
    [SerializeField] private int _countZombies;
    [SerializeField] private float _timeWait;
    private float _currentTime;
    
    private void Spawn(int _countWave) 
    {
        for (int i = 0; i < _countWave; i++) // счетчик волн
        {
            for (int z = 0; z < 5; z++) // Генерация врагов
            {
              int index = Random.Range(0, _positionSpawn.Length);
              Instantiate(_prefab, _positionSpawn[index].position, Quaternion.identity);
              _countZombies++;
            }
        }
    }
    private void Start()
    {
        _countWave =- 1;
    }
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_countZombies == 0)
        {
            _countWave++;
            Spawn(_countWave);
        }
    }
}
