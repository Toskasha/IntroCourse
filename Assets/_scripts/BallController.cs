using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody RB;
    public float speed;

	// Use this for initialization
	void Start ()
    {
        RB = GetComponent<Rigidbody>();
	}
    float test;
	// Update is called once per frame
	void Update ()
    {
        float LeftRight = Input.GetAxisRaw("Horizontal");
        float ForwardBack = Input.GetAxisRaw("Vertical");

        Vector3 Dir = new Vector3(LeftRight,0,ForwardBack);


        RB.AddForce(Dir*Time.deltaTime*speed);

        test += Time.deltaTime;

        Debug.Log(Time.deltaTime);
		
	}


}
