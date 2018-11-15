using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Start");
    }
	
	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position = transform.position + Vector3.forward * y + Vector3.left * x;



    }
}
