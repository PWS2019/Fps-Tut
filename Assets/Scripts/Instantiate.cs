using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    public Rigidbody BulletPrefab;
    public Transform BarrelEnd;
	
	
	void Update () {
		if (Input.GetButtonDown("Fire"))
        {
            Rigidbody BulletInstance;
            BulletInstance = Instantiate(BulletPrefab, BarrelEnd.position, BarrelEnd.rotation) as Rigidbody;
            BulletInstance.AddForce(BarrelEnd.forward * 5000);
        }
	}
}
