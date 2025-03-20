using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void GoToLevel()
    {
        SceneManager.LoadScene("Game");
    }
}