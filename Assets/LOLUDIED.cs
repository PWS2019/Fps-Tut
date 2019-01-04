using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOLUDIED : MonoBehaviour
{

    public AudioSource Audio;

    void Update()
    {
        if (GlobalHealth.PlayerHealth == 0)
        {
            Audio.Play();
            

        }
    }
}
