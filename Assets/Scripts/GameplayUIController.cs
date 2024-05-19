using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }


    public void GoHome()
    {
        SceneManager.LoadScene("Main Menu");
    }







}//class
