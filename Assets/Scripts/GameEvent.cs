using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvent : GameManager
{
    public UnityEvent colection;
    public GameObject gameOverScreen;
    public GameObject cancelGame;
    public GameObject cancelController;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        cancelGame.SetActive(false);
        cancelController.SetActive(false);
    }
}