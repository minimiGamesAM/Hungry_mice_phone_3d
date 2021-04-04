using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// test game
/// </summary>

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitAplication()
    {
        Application.Quit();
    }

}
