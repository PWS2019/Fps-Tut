using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMoveScript06 : MonoBehaviour
{

    public float moveForce = 0f;
    private Rigidbody rbody;
    public int HP = 0;
    public Slider HPBar;

    // Use this for initialization
    void Start()
    {

        rbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal") * moveForce;
        float v = Input.GetAxisRaw("Vertical") * moveForce;

        rbody.velocity = transform.TransformVector(h, 0, v);

        HPBar.value = HP;


    }
}
