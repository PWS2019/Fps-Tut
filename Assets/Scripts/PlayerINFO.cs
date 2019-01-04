using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerINFO : MonoBehaviour {

    private int _health;

   

	// Use this for initialization
	void Start () {
        _health = 100;
	}

    public void hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health" + _health);
    }
	
	
}
