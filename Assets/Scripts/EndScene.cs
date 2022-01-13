using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    void OnTriggerEnter(Collider Player)
    {
        SceneManager.LoadScene(0);
    }
}
