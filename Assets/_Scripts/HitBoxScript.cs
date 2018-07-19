using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxScript : MonoBehaviour {

    public float DamageAmount = 10;

    public void OnTriggerEnter(Collider other)
    {
        var ObjectHealth = other.GetComponent<DamScript>();

        if (ObjectHealth != null && other.CompareTag("Player"))
        {
            ObjectHealth.TakeDamage(DamageAmount);
        }


    }
}
