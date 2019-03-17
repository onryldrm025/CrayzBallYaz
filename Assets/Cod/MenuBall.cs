using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBall : MonoBehaviour {

	
	void Start () {
		
	}
	
	
	void Update () {
        Vector3 rota = new Vector3(0, 45, 90);  // x 15 derece y 45 z 90 derece veriyoruz.
        transform.Rotate(rota * Time.deltaTime);

    }
}
