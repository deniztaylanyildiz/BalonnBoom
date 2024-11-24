using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonController : MonoBehaviour
{
    Controller ControlScript;
    
    public GameObject Bommer;



    private void Start()
    {
        ControlScript = GameObject.Find("Controlroom").GetComponent<Controller>();
    }
    private void OnMouseDown()
    {
        GameObject Of= Instantiate(Bommer,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(Of,0.34F);
        ControlScript.pointCalulator();
    }
}
