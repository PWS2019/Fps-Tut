using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RecoilI : MonoBehaviour
{
    void mfRecoil() {
        transform.localEulerAngles = new Vector3(Random.Range(transform.localEulerAngles.x - 2f, transform.localEulerAngles.x - 3f), Random.Range(transform.localEulerAngles.y - 2f, transform.localEulerAngles.y + 2f), transform.localEulerAngles.z); }
}
