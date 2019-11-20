using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "key")
        {
            anim.enabled = true;
     

        }

    }
}
