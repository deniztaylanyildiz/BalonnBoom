using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    public GameObject baloon;
    float createBaloon = 1.5F;
    float timeScale = 0F;
    Controller GameControl;
    // Start is called before the first frame update
    void Start()
    {
        GameControl=this.gameObject.GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        timeScale -= Time.deltaTime;
        if (timeScale < 0 && GameControl.TimeScaler>0)
        {
          GameObject go = Instantiate(baloon,new Vector3(Random.Range(-2.07F, 2.07F), -6.36F, 0),Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Random.Range(40f,110f)));
          
            
            timeScale = createBaloon;

        }
    }
}
