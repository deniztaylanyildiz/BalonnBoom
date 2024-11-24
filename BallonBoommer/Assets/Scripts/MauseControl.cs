using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MauseControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        print("Clicked");
    }
    private void OnMouseDrag()
    {
       Vector2 pos= Input.mousePosition;
        Vector3 objPos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x,pos.y,1f));
        transform.position = objPos;

    }
}
