using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    //M�todo para carregar nova cena.
    public void LoadScenes(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    //M�todo para carregar nova cena.
}
