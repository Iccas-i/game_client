using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTower : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;
    public void SpawnTower(Transform tileTransform)
    {
        Instantiate(towerPrefab, tileTransform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()

    {
        /*
        if (Input.GetMouseButtonDown(0))

        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Physics.Raycast(ray, out hit);



            if (hit.collider != null)

            {

                CurrentTouch = hit.transform.gameObject;

                EventActivate();

            }

        }
        */
    }
}
