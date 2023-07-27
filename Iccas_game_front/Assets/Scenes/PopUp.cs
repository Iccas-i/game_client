using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPopup : MonoBehaviour
{
    public GameObject popupPanel;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(clickPosition);

            if (collider != null && collider.gameObject == gameObject)
            {
                ShowPopup();
            }
            else
            {
                HidePopup();
            }
        }
    }

    public void ShowPopup()
    {
        popupPanel.SetActive(true);
    }

    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}