using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTest : MonoBehaviour
{
    public Animation anim;
    public bool winEnabled;

    GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        score = 

        anim = gameObject.GetComponent<Animation>();
        anim.enabled = false;
        //_Animation = gameObject.GetComponentInParent<Animation>;
        //Debug.Log(m_Animation.name.ToString());
        //print(m_Animation.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(anim.name);
 
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {

            if (winEnabled)
            {

            }


            foreach (AnimationState state in anim)
            {
                state.speed = 0.16F;
            }

            anim.enabled = true;
            Debug.Log("got key");
        }
    }
}
