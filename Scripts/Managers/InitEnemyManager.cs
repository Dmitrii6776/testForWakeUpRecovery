using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitEnemyManager : MonoBehaviour
{
    private EnemyController _enemyController;
    private EnemyModel _enemyModel;
    [SerializeField] private EnemyView[] _enemyViews;
    void Awake()
    {
        foreach (var enemyView in _enemyViews)
        {
            var enemyViewC = enemyView.gameObject.GetComponent<EnemyView>();
            _enemyModel = new EnemyModel();
            _enemyController = new EnemyController(_enemyModel, enemyViewC);
            enemyViewC.enemyController = _enemyController;  
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
