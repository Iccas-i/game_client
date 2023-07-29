using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{
    int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void NextScene()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
    //public void SceneChange()
    //{
      //  SceneManager.LoadScene("Team_Contribute");
    //}
}
