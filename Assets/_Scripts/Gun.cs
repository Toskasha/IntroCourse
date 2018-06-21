using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public int Mag = 20;

    public float FireRate = .1f;

    private float SetFireDelay;

    public GameObject bulletPrefab;

    public void Fire()
    {
         if(Mag > 0 && SetFireDelay <= 0)
        {
            GameObject TempBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            TempBullet.GetComponent<Rigidbody>().velocity = transform.forward * 100;

            SetFireDelay = FireRate;
            Mag--;
        }

    }
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SetFireDelay -= Time.deltaTime;
	}
}
