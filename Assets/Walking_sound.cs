using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Walking_sound : MonoBehaviour
{
    public AudioSource concrete1;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerable Walking()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            concrete1.Play(); 
            yield return new WaitWhile(() => concrete1.isPlaying);
            concrete1.Play();
        }
        
    }
}