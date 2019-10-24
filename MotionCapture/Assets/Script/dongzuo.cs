using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dongzuo : MonoBehaviour {
    Animator myAnimator;
	// Use this for initialization
	void Start ()
    {
        myAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("Hip Hop on");
        }
        if (Input.GetKey(KeyCode.R))
        {
            myAnimator.SetBool("Run on", true);
        }
        else
        {
            myAnimator.SetBool("Run on", false);

        }

    }
}
