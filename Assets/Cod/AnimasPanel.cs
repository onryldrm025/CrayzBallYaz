using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimasPanel : MonoBehaviour {

    public GameObject panel;
    int number = 1;
    Animator animasyon;
	void Start () {
       animasyon = panel.GetComponent<Animator>();
      
    }
	
	
	void Update () {
        if(number==1)
        {
            
            number = 2;
        }



    }
}
