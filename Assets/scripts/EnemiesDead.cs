using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemiesDead : MonoBehaviour
{
    public int scene;
    void Update()
    {
        print(GameObject.FindGameObjectsWithTag("Opponent").Length);

        if (GameObject.FindGameObjectsWithTag("Opponent").Length == 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
