using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Map : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Team_Map"); 
    }
}