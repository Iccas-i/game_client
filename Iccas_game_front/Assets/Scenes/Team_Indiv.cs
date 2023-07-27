using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Team_Indiv : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Team_Map");
        
    }
}