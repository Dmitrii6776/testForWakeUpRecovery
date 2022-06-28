using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InputManager : MonoBehaviour
{
    private PlayerView PlayerView;
     public InitPlayerManager initPlayerManager;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerView = initPlayerManager.playerView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            PlayerView.SetPosition(mousePosition);
        }
        
    }
}
