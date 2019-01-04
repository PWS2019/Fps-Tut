using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSphere : MonoBehaviour {

    public float speed = 10.0f;
    public int damage = 10;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {
        PlayerINFO player = other.GetComponent<PlayerINFO>();
        if (player != null)
        {
            player.hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
