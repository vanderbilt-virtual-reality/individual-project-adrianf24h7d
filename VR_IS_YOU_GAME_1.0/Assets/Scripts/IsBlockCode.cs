using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBlockCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        string adjacent = checkObjectType(other);
     

    }
    

    //Checks Collided Object Type
    public string checkObjectType(Collider other)
    {
        string type = other.name;
        return type;
    }

    }
