using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;  // Maksimum can miktarý
    private float currentHealth;    // Mevcut can

    public Animator animator;  // Karakterin animatörüne referans (gerekirse can ölünce animasyon oynatabilirsiniz)

    void Start()
    {
        currentHealth = maxHealth;  // Baþlangýçta can deðeri maksimum olacak
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;  // Hasar al
        Debug.Log("Hasar aldý! Kalan Can: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();  // Eðer can sýfýrlandýðýnda ölüm iþlemi
        }
    }

    void Die()
    {
        // Ölüm animasyonu ekleyebilirsiniz
        if (animator != null)
        {
            animator.SetTrigger("Die");  // Ölüm animasyonu tetiklensin (animasyon parametresinin adý 'Die' olarak ayarlanmalý)
        }

        // Bu noktada karakterin ölmesi için yapýlacak iþlemleri ekleyebilirsiniz (örneðin sahneden kaldýrma)
        Destroy(gameObject);
    }
}
