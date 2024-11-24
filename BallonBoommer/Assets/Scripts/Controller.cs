using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float TimeScaler ;
    int BaloonPointer=0;
    public Text TimeText, PointerText;
    public GameObject Boomerr;
    
    private void Start()
    {
        PointerText.text=""+BaloonPointer;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeScaler>0)
        {
            TimeScaler -= Time.deltaTime;
            TimeText.text = "" + (int)TimeScaler;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Baloon");
            for (int i= 0;i<go.Length;i++) {
                Instantiate(Boomerr, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }
        
    }
    public void pointCalulator()
    {
        BaloonPointer +=1;
        PointerText.text = "" + BaloonPointer;

    }

}
