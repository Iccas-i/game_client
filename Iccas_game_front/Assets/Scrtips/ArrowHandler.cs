using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowHandler : MonoBehaviour
{

    float time;

    // Update is called once per frame
    void Update()
    {
        if (time < 0.5f)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 100, 255, 1 - time);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 100, 255, time);
            if (time > 1f)
            {
                time = 0;
            }
        }

        time += Time.deltaTime;

    }


}