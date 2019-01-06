using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PistolSFX : MonoBehaviour
{
    public AudioSource Shot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot.Play();

        }
    }
}
