using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBlock02 : MonoBehaviour
{
    GameObject referenceObj;
    keyScript02 referenceScr;


    private bool grabT = false;

    // Start is called before the first frame update
    void Start()
    {
        referenceObj = GameObject.FindGameObjectWithTag("key");
        referenceScr = referenceObj.GetComponent<keyScript02>();


    }

    // Update is called once per frame
    void Update()
    {

        if (grabT)
        {
            referenceScr.changeToGrab();
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "grab")
        {
            grabT = true;
        }
    }

}
