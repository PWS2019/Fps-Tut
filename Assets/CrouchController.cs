using UnityEngine;
using System.Collections;

public class CrouchController : MonoBehaviour
{


    public CharacterController characterController;

    void Start()
    {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            characterController.height = 1f;
        }
        else
        {
            characterController.height = 1.8f;
        }
    }
}
