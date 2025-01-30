using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 5;
    public TextMeshProUGUI healthText;

    private void OnMouseDown()
    {
        TakeDamage(1); // Reduce health by 1 when clicked
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "HP: " + health;
        }
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        UpdateHealthUI();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthUI();
    }


    // Update is called once per frame
    void Update()
    {

        
    }
}
