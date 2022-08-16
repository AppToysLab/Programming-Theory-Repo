using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    public void GoToMenu(int number)
    {
        SceneManager.LoadScene(number);
    }
}
