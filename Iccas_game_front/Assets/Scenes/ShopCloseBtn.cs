using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/*
public class ShopCloseBtn : MonoBehaviour
{
    public ShopHandler popupWindow;

    public void OnButtonClick()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOScale(0.95f, 0.1f));
        seq.Append(transform.DOScale(1f, 0.1f));

        seq.Play().OnComplete(() => {
            popupWindow.Hide();
        });
    }
}*/
public class ShopCloseBtn : MonoBehaviour
{
    void Update() => this.gameObject.SetActive(true);//씬이호출될때 표시되지않게함

}