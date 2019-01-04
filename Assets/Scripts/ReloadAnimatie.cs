using UnityEngine;
using UnityEngine.Animations;

public class ReloadAnimatie : MonoBehaviour
{
    Animation m_Animator;
    


    void Start()
    {
        //Fetch the Animator from your GameObject
        m_Animator = GetComponent<Animation>();
        
    }
        

    private void Update()
    {
        //Press the space key to play the "Jump" state
        if (Input.GetButtonDown("Reload"))
        {
         m_Animator.Play("Reload Animation");
        }


    }
}

