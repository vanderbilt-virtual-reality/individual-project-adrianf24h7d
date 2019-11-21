using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBlock : MonoBehaviour
{
    private int defaultLayer = 0;
    private int grabLayer = 9;

    public bool touchWin = false;
    public bool touchGrab = false;
    public bool touchBox = false;
    public bool touchFlag = false;
    public bool touchText = false;
    public bool touchkey = false;

    GameObject referenceObject;
    keyScript referenceScript;

    // Start is called before the first frame update
    void Start()
    {
        referenceObject = GameObject.FindWithTag("key");
        referenceScript = referenceObject.GetComponent<keyScript>();


        referenceObject.layer = defaultLayer;
    }

    // Update is called once per frame
    void Update()
    {
  
        touchkey = true;
        touchGrab = true;

       
        if(touchkey && touchGrab)
        {

            referenceScript.keyLevelToChange = grabLayer;
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "key")
        {
            touchkey = true;
        }
        if (other.name == "grab")
        {
            touchGrab = true;
        }
        if (other.name == "win")
        {
            touchWin = true;
        }
        if (other.name == "box")
        {
            touchBox = true;
        }
        if(other.name == "flag")
        {
            touchFlag = true;
        }
        if(other.name == "text")
        {
            touchText = true;
        }
    }
 }
