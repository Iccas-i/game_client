using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2Result : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Team_Result");
    }
}
