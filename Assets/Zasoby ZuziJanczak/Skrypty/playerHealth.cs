using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;
    

    [SerializeField] UnityEvent Death;
    

    private bool isDead;
      

    void Start()
    {
        maxHealth = health;
        
    }

    // 
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 && !isDead)
        {
            isDead = true;
                            
            Debug.Log("œmieræ");

            Death.Invoke();

            gameObject.SetActive(false);


        }
    }

    void TakeDemage(int amount)
    {
        health -= amount;

        
    }
}
