using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Método para carregar nova cena.
    public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    public void ExitGame()
    {
       Application.Quit();
    }
    //Método para carregar nova cena.

}
