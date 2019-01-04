using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followharold : MonoBehaviour
{

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 10;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public RaycastHit Shot;

    public GameObject BulletSPPrefab;
    private GameObject BulletSP;

    void Update()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerINFO>())
            {
                if (BulletSP == null)
                {
                    BulletSP = Instantiate(BulletSPPrefab) as GameObject;
                    BulletSP.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    BulletSP.transform.rotation = transform.rotation;
                }
            }
            else if (hit.distance < AllowedRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }


    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

}