using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

// Remember to inherit from Network Behavior if this is a networked object
public class MoveScript : NetworkBehaviour {

    // Reference to the rigidbody component
    public Rigidbody rigidBody;

    // Use this for initialization
    void Start () {
        Debug.Log("hello");
    }

    // Called when the local player is started
	public override void OnStartLocalPlayer() {
        Camera.main.GetComponent<CameraScript>().target = transform;
        // GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    // void Update () {
    //     float x = Input.GetAxis("Horizontal");
    //     float y = Input.GetAxis("Vertical");

    //     float rx = Input.GetAxis("Mouse X");
    //     float ry = Input.GetAxis("Mouse Y");


    //     transform.Translate(x, 0f, y);
    //     transform.Rotate(0f, rx, 0f);
    // }

    void Update () {

		if (!isLocalPlayer) {
            return;
        }

        float x = Input.GetAxis("Horizontal") * 0.5f;
        float y = Input.GetAxis("Vertical") * 0.5f;

        float rx = Input.GetAxis("Mouse X");
        float ry = Input.GetAxis("Mouse Y");



        transform.Translate(x, 0f, y);
        // rigidBody.AddForce(x, 0f, y, ForceMode.Acceleration);
        // rigidBody.rotation = Quaternion.Euler(0f, 0f, 0f);

        transform.Rotate(0f, rx, 0f);
    }
}
