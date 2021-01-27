using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    public GameObject cutPrefab;
    public float cutTrailLifetime;

    bool dragging;
    Vector2 swipeStart;

    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragging = true;
            // metatropi tis 8esis tou pontikiou stis diastasois tis o8onis
            swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0) && dragging)
        {
            dragging = false;
            SpawnCut();
        }
    }

    void SpawnCut()
    {
        // orismos se poio simio stamataei to kopsimo tis lepidas
        Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // orismos se poio tertatimorio ksekinaei kai stamatia to kopsimo
        GameObject cutInstance = Instantiate(cutPrefab, swipeStart, Quaternion.identity);
        cutInstance.GetComponent<LineRenderer>().SetPosition(0, swipeStart);
        cutInstance.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);

        // orismos gia tin epafi
        Vector2[] colliderPoints = new Vector2[2];
        colliderPoints[0] = new Vector2(0, 0);
        colliderPoints[1] = swipeEnd - swipeStart;
        cutInstance.GetComponent<EdgeCollider2D>().points = colliderPoints;
        
        // to kopsimo tis lepidas eksafanizetai meta apo ton xrono pou exoume orisei
        Destroy(cutInstance, cutTrailLifetime);

    }


}
