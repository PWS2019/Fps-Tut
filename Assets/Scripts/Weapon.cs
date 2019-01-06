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
    public AudioSource AK_47;

    public GameObject bulletHole;

    public float delayTime = 0.5f;

    private float counter = 0;



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
           AK_47.Play();
            CurrentBullets--;
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

 

  

    void FixedUpdate()
    {

        if (Input.GetButtonDown("Fire1"))
        {                   
                       
            RaycastHit hit;

            Ray ray = new Ray(transform.position, transform.forward);

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                Instantiate(bulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));

            }
            
        }
        
    }
}



 			


