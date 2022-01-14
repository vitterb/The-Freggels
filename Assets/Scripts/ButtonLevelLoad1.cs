using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevelLoad1 : MonoBehaviour
{

    public string levelToLaod;


    public void LoadLevel()
    {
        //load new level
        SceneManager.LoadScene(levelToLaod);
    }
}
