using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CloseButtonHandler : MonoBehaviour
{
    public float close;
    public float closeX;
    public float closeY;

    public PanelHandler popupWindow;

    public void OnButtonClick()
    {
        var seq = DOTween.Sequence();

        seq.Append(transform.DOScale(close, 0.1f));
        seq.Append(transform.DOScaleX(close, 0.1f));
        seq.Append(transform.DOScaleY(close, 0.1f));

        seq.Play().OnComplete(() => {
            popupWindow.Hide();
        });
    }
}