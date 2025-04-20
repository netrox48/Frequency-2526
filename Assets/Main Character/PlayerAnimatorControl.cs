using DG.Tweening;
using UnityEngine;

public class PlayerAnimatorControl : MonoBehaviour
{
    public GameObject impactEffect;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", true);
            transform.Translate(5 * Time.deltaTime * Vector3.forward);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRunning", true);
            transform.Translate(7 * Time.deltaTime * Vector3.forward);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("isBackward", true);
            transform.Translate(3 * Time.deltaTime * -Vector3.forward);
        }
        else
        {
            animator.SetBool("isBackward", false);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("isSneaking", true);
            transform.Translate(1 * Time.deltaTime * Vector3.forward);
        }
        else
        {
            animator.SetBool("isSneaking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jumping");
            transform.DOMoveY(2.5f, 0.4f);
            transform.DOMoveY(0, 0.4f).SetDelay(0.4f).OnComplete(CloseTheEffect);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("slide");
            transform.DOMove(transform.position + transform.forward * 2f, 0.4f);
        }
    }

    void CloseTheEffect()
    {
        impactEffect.SetActive(false);
    }
}
