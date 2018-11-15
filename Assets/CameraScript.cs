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
		Vector3 newposition = target.position;
        transform.position = Vector3.Lerp(transform.position, newposition, Time.deltaTime * 5f);

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

		Vector3 newrotation = transform.rotation.eulerAngles + Vector3.up * x + Vector3.left * y;

        transform.rotation = Quaternion.Euler(newrotation);

    }

 }
