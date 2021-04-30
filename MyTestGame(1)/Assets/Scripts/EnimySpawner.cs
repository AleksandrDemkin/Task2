using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enimy; // Наша мина
    [SerializeField] private Transform _menimySpawnPlace; // точка, где создается мина

    private void Start()
    {
        Instantiate(_enimy, _menimySpawnPlace.position, _menimySpawnPlace.rotation);
         // Создаем _enimy в точке _mineSpawnPlace
    }
}
