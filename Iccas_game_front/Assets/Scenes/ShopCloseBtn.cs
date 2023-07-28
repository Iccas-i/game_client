using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ShopCloseBtn : MonoBehaviour
{
    public ShopHandler popupWindow;

    public void OnButtonClick()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOScale(0.95f, 0.1f));
        seq.Append(transform.DOScale(1.05f, 0.1f));
        seq.Append(transform.DOScale(1f, 0.1f));
        seq.Append(transform.DOScaleY(3, 0.01f));

        seq.Play().OnComplete(() => {
            popupWindow.Hide();
        });
    }
}