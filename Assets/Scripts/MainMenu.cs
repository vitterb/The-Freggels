using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayAir()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySpace()
    {
        SceneManager.LoadScene(2);
    }
}
