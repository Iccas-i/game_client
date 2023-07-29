using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Move : MonoBehaviour
{
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Translate(speed, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        while (true)
        {

                this.transform.Translate(-speed, 0, 0);

                if (this.gameObject.transform.position.x <= -7.2)
                {
                    this.transform.Translate(speed, 0, 0);
                }
        }
        
    }
}