using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject ball;     // Top
    public GameObject panel;
  
    Animator animasyon;
   

    Vector3 camoffset;          // Kemera position verisi tutulucak
	void Start () {
        animasyon =panel.GetComponent<Animator>();
       
        camoffset = this.transform.position - ball.transform.position;   // Kermera ve top arasındaki mesefa hesabı.
        animasyon.SetTrigger("Come");
       
        

    }
	
	void Update () {

        this.transform.position = ball.transform.position + camoffset; // Top ile arasındaki mesafeyi korulması için yazılan kod satırı.
		
	}
}
