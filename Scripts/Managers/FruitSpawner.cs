using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] FruitsPrefab;
    private float _startDelay = 2f;
    private float _repeatDelay = 1f;


    private void Start()
    {
        InvokeRepeating("SpawnFruit", _startDelay, _repeatDelay);
    }

    private GameObject GetRandomFruit()
    {
        var randomNum = Random.Range(0, FruitsPrefab.Length - 1);
        return FruitsPrefab[randomNum];
    }

    private Vector2 GetRandomPositon()
    {
        var randomX = Random.Range(2.3f, -2.3f);
        var randomY = Random.Range(-3.96f, 3.96f);
        var position = new Vector2(randomX, randomY);
        return position;
    }

    private void SpawnFruit()
    {

        Instantiate(GetRandomFruit(), GetRandomPositon(), Quaternion.identity);
    }
}
