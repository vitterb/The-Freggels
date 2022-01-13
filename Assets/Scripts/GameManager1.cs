using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    public GameObject player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    public enum GameState
    {
        Playing,
        GameOver
    }
    public GameState gamestate = GameState.Playing;
    private Health PlayerHealth;



    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        PlayerHealth = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        //statemachine of game
        switch (gamestate)
        {
            case GameState.Playing:
                if (PlayerHealth.isAlive == false)
                {
                    gamestate = GameState.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }

                break;
        }
    }
}
