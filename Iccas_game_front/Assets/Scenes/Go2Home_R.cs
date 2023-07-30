using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Go2Home_R : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void OnClick()
    {
        SceneManager.LoadScene("Home_Result");
    }
}
