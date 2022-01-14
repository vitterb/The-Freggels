using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLoad : MonoBehaviour
{
    public string mLevelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(mLevelToLoad);
    }
}
