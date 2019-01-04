using UnityEngine;
using UnityEngine.Animations;

public class Weapon : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public int BulletsPerMag = 22;
    public int BulletsLeft = 132;
    public int CurrentBullets;
    public float FireRate = 0.1f;
    public float fireTimer;
    public RecoilDos RecoilObject;

    public Camera fpsCam;
    Animation m_Animator;

    private bool Patat = true;

    private void Start()
    {
        CurrentBullets = BulletsPerMag;
        m_Animator = GetComponent<Animation>();

    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

        }
        else if (CurrentBullets == 1)
        {
            m_Animator.Play("Reload Animation");
        }



        if (fireTimer > FireRate)
            fireTimer += Time.deltaTime;

        //if (CurrentBullets == 1)
        // {


        // }


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
                BulletsLeft -= 22;
                CurrentBullets += 22;
                Reload();
            }
            if (BulletsLeft == 0)
            {
                return;

            }


        }

    }
    void Reload()
    {
        if (BulletsLeft == 0)
        {
            BulletsLeft -= 132;

        }
    }

    void DestroyAll(string Bullet)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Bullet");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }

    void mfRecoil()
    {
        transform.localEulerAngles = new Vector3(Random.Range(transform.localEulerAngles.x - 2f, transform.localEulerAngles.x - 3f), Random.Range(transform.localEulerAngles.y - 2f, transform.localEulerAngles.y + 2f), transform.localEulerAngles.z);
    }


    public GameObject bulletHole;
    public float shootDistance;

    void b_Bullet()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray bullet = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(bullet, out hit, shootDistance))
            {
                if (hit.collider.tag == "Wall")
                {
                    Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.forward, hit.normal));
                }
            }
        }

    }
}

 			


