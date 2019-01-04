using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour
{

    public GameObject Flash;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {           
            Flash.SetActive(true);
            StartCoroutine(MuzzleOff());
        }
    }

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        Flash.SetActive(false);
    }
}