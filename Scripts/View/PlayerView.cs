using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerView : MonoBehaviour
{
    public PlayerController playerController;

   [SerializeField] private TextMeshProUGUI _livesCount;
   [SerializeField] private TextMeshProUGUI _score;

   private void Start()
   {
       playerController.OnStart();
   }

   public void SetPosition(Vector2 position)
    {
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D other)
   


    {
        Debug.Log("coll");
        playerController.OnCollision(other.gameObject);
    }
    
    public void DestroyGameObg(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    public void SetScore(int intScore)
    {
        // _score.text = $"Score: " +
        //               $"{intScore.ToString()}";
        _score.text = intScore.ToString();
        
    }

    public void SetLives(int intLives)
    {
        // _livesCount.text = $"Lives: " +
        //                    $"{intLives.ToString()}"
        
        _livesCount.text = intLives.ToString();
    }
}
