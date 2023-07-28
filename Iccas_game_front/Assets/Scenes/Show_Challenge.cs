using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Show_Challenge : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Team_Map"); 
    }
}