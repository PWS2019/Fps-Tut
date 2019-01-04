using System.Collections;
using UnityEngine;

public class Color_Bullet : MonoBehaviour {

    public Material matofobject;
    public Color newcol;
    public KeyCode changecol;

	// Use this for initialization
	void Start () {
        matofobject.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		if (matofobject.color == Color.black)
        {
            matofobject.color = newcol;
        }
        else
        {
            matofobject.color = Color.black;
        }
	}
}
