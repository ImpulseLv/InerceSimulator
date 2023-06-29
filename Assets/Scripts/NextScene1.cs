using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene1 : MonoBehaviour
{
    public void LoadScene(int scenas)
    {
        SceneManager.LoadScene(scenas);
    }
}
