using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public EnemyController enemyController;
    private Vector2 _position;

    private int _speed;
    // Start is called before the first frame update
    void Start()
    {
        _position = enemyController.GetPosition();
        _speed = enemyController.GetSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == _position.x && transform.position.y == _position.y)
        {
            _position = enemyController.GetPosition();
            
            
        }
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _position, _speed * Time.deltaTime);
    }
}
