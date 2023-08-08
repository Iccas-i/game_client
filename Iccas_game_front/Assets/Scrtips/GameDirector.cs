using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject hpbar;
    // Start is called before the first frame update
    void Start()
    {
        this.hpbar = GameObject.Find("hpbar");
    }

    public void DecreaseHP()
    {
        this.hpbar.GetComponent<Image>().fillAmount -= 0.1f;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
