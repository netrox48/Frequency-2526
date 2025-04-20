using DG.Tweening;
using UnityEngine;

public class BossAnimation : MonoBehaviour
{
    private Animator BossAnimator;

    void Start()
    {
        BossAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            BossAnimator.SetBool("Walking", true);
            transform.Translate(7 * Time.deltaTime * Vector3.forward);
        }
        else
        {
            BossAnimator.SetBool("Walking", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            BossAnimator.SetBool("WalkingBack", true);
            transform.Translate(7 * Time.deltaTime * -Vector3.forward);
        }
        else
        {
            BossAnimator.SetBool("WalkingBack", false);
        }


    }

}