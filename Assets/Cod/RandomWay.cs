using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWay : MonoBehaviour {

    public GameObject way1;
    public GameObject way2;

    float way1z;
    float way2z;

	void Start () {
       
	
	}
    void OnTriggerEnter(Collider Col)
    {
        way1z = way1.transform.position.z;
        way2z = way2.transform.position.z;
        if (way1z<way2z)
        {
            way1z = way1z + 30;

            way1.transform.position = new Vector3(way1.transform.position.x, way1.transform.position.y, way1z);



        }





    }

}
