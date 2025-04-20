using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;  // Maksimum can miktar�
    private float currentHealth;    // Mevcut can

    public Animator animator;  // Karakterin animat�r�ne referans (gerekirse can �l�nce animasyon oynatabilirsiniz)

    void Start()
    {
        currentHealth = maxHealth;  // Ba�lang��ta can de�eri maksimum olacak
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;  // Hasar al
        Debug.Log("Hasar ald�! Kalan Can: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();  // E�er can s�f�rland���nda �l�m i�lemi
        }
    }

    void Die()
    {
        // �l�m animasyonu ekleyebilirsiniz
        if (animator != null)
        {
            animator.SetTrigger("Die");  // �l�m animasyonu tetiklensin (animasyon parametresinin ad� 'Die' olarak ayarlanmal�)
        }

        // Bu noktada karakterin �lmesi i�in yap�lacak i�lemleri ekleyebilirsiniz (�rne�in sahneden kald�rma)
        Destroy(gameObject);
    }
}
