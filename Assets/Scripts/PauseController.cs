using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("Escape"))
        {
            GameStates currentGameState = GameStatesManager.Instance.CurrentGameState;
            GameStates newGameState = currentGameState == GameStates.Gameplay
                ? GameStates.Paused
                : GameStates.Gameplay;

            GameStatesManager.Instance.SetState(newGameState);
        }
    }
}
