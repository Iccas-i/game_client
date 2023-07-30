using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Go2Home : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void OnClick()
    {
        SceneManager.LoadScene("Home");
    }
}
