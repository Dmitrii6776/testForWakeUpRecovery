using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    private EnemyModel _enemyModel;
    private EnemyView _enemyView;

    public EnemyController(EnemyModel enemyModel, EnemyView enemyView)
    {
        this._enemyModel = enemyModel;
        this._enemyView = _enemyView;
    }

    public Vector2 GetPosition()
    {
        var randomX = Random.Range(2.3f, -2.3f);
        var randomY = Random.Range(-3.96f, 3.96f);
        var position = new Vector2(randomX, randomY);
        return position;
    }

    public int GetSpeed()
    {
        return _enemyModel.speed;
    }
    
    
}
