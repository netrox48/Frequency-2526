using DG.Tweening;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    private Animator EnemyAnimator;

    void Start()
    {
        EnemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            EnemyAnimator.SetBool("Walk", true);
            transform.Translate(7 * Time.deltaTime * Vector3.forward);
        }
        else
        {
            EnemyAnimator.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            EnemyAnimator.SetBool("WalkBack", true);
            transform.Translate(7 * Time.deltaTime * -Vector3.forward);
        }
        else
        {
            EnemyAnimator.SetBool("WalkBack", false);
        }

    }
}
