using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldRotation : MonoBehaviour {

	//gold Dönmesini sağlamal
	void Start () {
		
	}
	
	
	public void Update () {
        Vector3 rota = new Vector3(0, 65, 0);  // x 15 derece y 45 z 90 derece veriyoruz.
        transform.Rotate(rota * Time.deltaTime) ; //rota kadar don ama yavaş dönmesi için time ile çarpıyoruz.

		
	}
}
