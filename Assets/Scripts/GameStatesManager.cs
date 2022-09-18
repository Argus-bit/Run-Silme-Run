using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatesManager : MonoBehaviour
{
    private static GameStatesManager _instance;
    public static GameStatesManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameStatesManager();

            return _instance;
        }
    }

    public GameStates CurrentGameState { get; private set; }

    public delegate void GameStateChangeHandler(GameStates newGameState);
    public event GameStateChangeHandler OnGameStateChanged;

    private GameStatesManager()
    {

    }

    public void SetState(GameStates newGameState)
    {
        if (newGameState == CurrentGameState)
            return;

        CurrentGameState = newGameState;
        OnGameStateChanged?.Invoke(newGameState);
    }
}
