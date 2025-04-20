using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 2f;
    public float attackDistance = 2f;
    public float attackCooldown = 2f;

    private Animator animator;
    private float lastAttackTime;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > attackDistance)
        {

            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            transform.LookAt(player);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);

            if (Time.time > lastAttackTime + attackCooldown)
            {
                lastAttackTime = Time.time;
                animator.SetTrigger("punch");
            }
        }
    }
}
