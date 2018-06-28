using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamScript : MonoBehaviour {

    private float CurrentHealth;

    public int MaxHealth;

    public float RegenSpeed;

    public float DamTimer;
    private float CurrentDamTimer;

    
    

        
        

        

    

	// Use this for initialization
	void Start () {
		
	}

    public void TakeDamage(float DamageAmount)
    {
        CurrentHealth -= DamageAmount;
        CurrentDamTimer = DamTimer;
        Debug.Log(CurrentHealth);

        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
	
    public void HealthRegen(float Speed)
    {
        CurrentDamTimer -= Time.deltaTime;

        if(CurrentDamTimer <= 0 && CurrentHealth < MaxHealth)
        {
            CurrentHealth += Time.deltaTime * Speed;
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) { TakeDamage(10); }
	}
}
