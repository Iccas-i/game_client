using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Resolution : MonoBehaviour
{
    public int wIndex, hIndex;

    private void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(wIndex, hIndex, true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
