using UnityEngine;
using System.Collections;

public class HaroldEN : MonoBehaviour
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
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance < AllowedRange)
            {
                EnemySpeed = 0.01f;
                if (AttackTrigger == 0)
                {
                    TheEnemy.GetComponent<Animation>().Play("walking");
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                }
            }
            else
            {
                EnemySpeed = 0;
                TheEnemy.GetComponent<Animation>().Play("idle");
            }
        }

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerINFO>())
            {
                if (BulletSP == null)
                {
                    GlobalHealth.PlayerHealth -= 10;
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
