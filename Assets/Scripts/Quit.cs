using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is working!");
       
    }
}
