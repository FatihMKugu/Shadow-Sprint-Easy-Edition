using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScripts : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private AnimatorControllerParameter Run;
    private AnimatorControllerParameter Backward;
    private void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("WalkL", true);
            transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime); ;

            if (Input.GetKey(KeyCode.W))
            {
            transform.Translate(new Vector3(0, 0, 1f) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
            transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime);
            }
        }
        else { animator.SetBool("WalkL", false); }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("WalkR", true);
            transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime); ;

            if (Input.GetKey(KeyCode.W))
            {
            transform.Translate(new Vector3(0, 0, 1f) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
            transform.Translate(new Vector3(0, 0, -1f) * Time.deltaTime);
            }

        }
        else { animator.SetBool("WalkR", false); }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run", true);
            transform.Translate(new Vector3(0, 0, 3f) * Time.deltaTime); ;

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime); ;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime); ;
            }
        }
        else { animator.SetBool("Run", false); }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Backward", true);
            transform.Translate(new Vector3(0, 0, -3f) * Time.deltaTime);

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime); ;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime); ;
            }
        }
        else { animator.SetBool("Backward", false); }


    }

}
