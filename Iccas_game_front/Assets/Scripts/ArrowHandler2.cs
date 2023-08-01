using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowHandler2 : MonoBehaviour
{

    public float fadeInTime = 1.0f;

    private void Start()
    {
        StartCoroutine(SpriteFadeOut(GetComponent<SpriteRenderer>()));

    }

    IEnumerator SpriteFadeOut(SpriteRenderer _sprite)
    {
        Color tmpcolor = _sprite.color;

        while (tmpcolor.a >= 0.0f)
        {
            tmpcolor.a += Time.deltaTime / fadeInTime;
            _sprite.color = tmpcolor;

            if (tmpcolor.a >= 1f)
                tmpcolor.a = 1.0f;

            yield return null;
        }

        _sprite.color = tmpcolor;
    }


}