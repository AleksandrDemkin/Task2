using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enimy; // ���� ����
    [SerializeField] private Transform _menimySpawnPlace; // �����, ��� ��������� ����

    private void Start()
    {
        Instantiate(_enimy, _menimySpawnPlace.position, _menimySpawnPlace.rotation);
         // ������� _enimy � ����� _mineSpawnPlace
    }
}
