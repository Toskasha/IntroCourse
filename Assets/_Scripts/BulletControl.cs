using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    public float DamageAmount;

    public GameObject owner;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != owner)
        {
            other.gameObject.GetComponent<DamScript>().TakeDamage(DamageAmount);
            Destroy(gameObject);
        }
    }
}
