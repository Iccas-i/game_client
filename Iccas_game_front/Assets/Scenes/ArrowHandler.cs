using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowHandler : MonoBehaviour
{
    
    public float fadeOutTime = 1.0f;

    private void Start()
    {
       StartCoroutine (SpriteFadeOut(GetComponent<SpriteRenderer>()));
        
    }

    IEnumerator SpriteFadeOut(SpriteRenderer _sprite)
    {
        Color tmpcolor = _sprite.color;

        while (tmpcolor.a > 0.0f)
        {
            tmpcolor.a -= Time.deltaTime / fadeOutTime;
            _sprite.color = tmpcolor;

            if (tmpcolor.a <= 0f)
                tmpcolor.a = 0.0f;

            yield return null;
        }

        _sprite.color = tmpcolor;
    }


}