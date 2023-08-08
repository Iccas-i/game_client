using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10 || transform.position.x < -10)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > 20 || transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Collision.Gameobject.name == bullet)
        {
            Gameobject director = GameObject.Find("GameDirector");
            director.GetConponent<GameDirector>().DecreaseHP();
            Destory(gameObject);
        }
    }*/
    
}
