using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript02 : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.layer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeToGrab()
    {
        Debug.Log("madegrab");
        this.gameObject.layer = 9;
   
    }

}
