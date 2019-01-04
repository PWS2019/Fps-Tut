using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class shotsfx : MonoBehaviour
{
    public AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Audio.Play();

        }
    }
}
