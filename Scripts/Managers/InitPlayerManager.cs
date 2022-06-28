using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InitPlayerManager : MonoBehaviour
{
    public PlayerView playerView;

    public PlayerModel playerModel;

    public PlayerController playerController;
    public DataBase Base;
    
    // Start is called before the first frame update
    void Awake()
    {
        playerView = playerView.gameObject.GetComponent<PlayerView>();
        playerModel = new PlayerModel();
        playerController = new PlayerController(playerView, playerModel, Base);
        playerView.playerController = playerController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
