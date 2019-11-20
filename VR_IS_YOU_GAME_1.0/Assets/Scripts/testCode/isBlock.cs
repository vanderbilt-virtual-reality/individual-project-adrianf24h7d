using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBlock : MonoBehaviour
{
    public bool touchWin = false;
    public bool touchGrab = false;
    public bool touchBox = false;
    public bool touchFlag = false;
    public bool touchText = false;
    public bool touchkey = false;

    public GameObject referenceObject;
    public ScriptOne referenceScript;

    // Start is called before the first frame update
    void Start()
    {
        referenceObject = GameObject.FindObjectWithTag("key");
        referenceScript = referenceObject.GetComponent<keyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touchkey && touchGrab)
        {
            referenceScript.keyLevelToChange = 9;
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
