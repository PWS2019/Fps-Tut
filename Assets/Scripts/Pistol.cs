using UnityEngine;

public class Pistol : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public int BulletsPerMag = 15;
    public int BulletsLeft = 60;
    public int CurrentBullets;
    public float FireRate = 0.1f;
    public float fireTimer;

    public Camera fpsCam;



    private void Start()
    {
        CurrentBullets = BulletsPerMag;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if (fireTimer > FireRate)
            fireTimer += Time.deltaTime;
    }

    void Shoot()

    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            CurrentBullets--;
            fireTimer = 0.0f;

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (CurrentBullets == 0)
            {
                BulletsLeft -= 15;
                CurrentBullets = 15;

            }
            if (BulletsLeft == 0)
            {
                Reload();
                return;
            }
        }

    }
    void Reload()
    {
        if (BulletsLeft == 0)
        {
            BulletsLeft += 60;

        }
    }


}
