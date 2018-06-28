using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    public GameObject FocusPoint; //player or object followed

    private Vector3 Offset; //location relative to focus point

    public float InterpSpeed;

	// Use this for initialization
	void Start () {

        if (FocusPoint)
        {
            Offset = transform.position - FocusPoint.transform.position;
        }
        else
        {
            Debug.Log("No Focus Point");
        }

	}

    public void CamMoveTowards(float mspeed, Vector3 ML)
    {
        transform.position = Vector3.MoveTowards(transform.position, ML + Offset, mspeed * Time.deltaTime);
    }
 
    public void CamLerpTowards(float mspeed, Vector3 ML)
    {
        transform.position = Vector3.Lerp(transform.position, ML + Offset, mspeed * Time.deltaTime);
    }

	// Update is called once per frame
	void LateUpdate () {

        CamLerpTowards(InterpSpeed, FocusPoint.transform.position);
	}
}
