using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;
    private DataBase _base;

    public PlayerController(PlayerView playerView, PlayerModel playerModel, DataBase dataBase)
    {
        this._playerView = playerView;
        this._playerModel = playerModel;
        this._base = dataBase;
    }

    public void OnStart()
    {
        _playerView.SetLives(_playerModel.Lives);
        _playerView.SetScore(_playerModel.CurrentScore);
    }

    public void OnCollision(GameObject collision)
    {
        if (collision.CompareTag("Fruit"))
        {
            _playerView.DestroyGameObg(collision);
            SetScore();
            _playerView.SetScore(_playerModel.CurrentScore);
        }

        if (collision.CompareTag("Enemy"))
        {
            if (_playerModel.Lives > 0)
            {
                SetLives();
                _playerView.SetLives(_playerModel.Lives);
            }
            else
            {
                SetMaxScore();
                SceneManager.LoadScene(2);
                
            }
        }
    }

    private void SetScore()
    {
        _playerModel.CurrentScore += 1;
    }

    private void SetLives()
    {
        _playerModel.Lives -= 1;
    }

    private void SetMaxScore()
    {
        if (_base.MaxScore < _playerModel.CurrentScore)
        {
            _base.MaxScore = _playerModel.CurrentScore;
        }
    }
    
    

    
}
