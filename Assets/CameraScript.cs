using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
				// Move it backwards 5m and up 1m
        transform.position = target.position - target.forward * 5f + target.up * 1.5f;
        transform.rotation = Quaternion.Euler(0f, target.rotation.eulerAngles.y, 0f);
        
    }
}
