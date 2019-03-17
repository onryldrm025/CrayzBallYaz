using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAnimator : MonoBehaviour {

    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
        Invoke("Startanim", 1);
		
	}
    void Startanim()
    {
        anim.SetTrigger("Come");



    }

    void Update () {
		
	}
}
