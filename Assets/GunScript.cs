using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour {

    public GameObject explosion;
    public int ammo;
    public int maxammo;
    public Text ammotext;


    // Use this for initialization
    void Start () {
        ammo = 10;
    }
	
	// Update is called once per frame
	void Update () {
        bool fire = Input.GetButtonDown("Fire1");
        float y = Input.GetAxis("Mouse Y");

		Vector3 newrotation = transform.rotation.eulerAngles + Vector3.left * y;
        transform.rotation = Quaternion.Euler(newrotation);

        ammotext.text = ammo.ToString();

        if (fire && ammo > 0) {
            Debug.Log("Fire");
            ammo -= 1;


            RaycastHit hit; 

            if (Physics.Raycast(transform.position, transform.forward, out hit)) {
                Debug.Log("Hit something");
                Debug.Log(hit.collider);

				GameObject impactObject = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
				Destroy(impactObject, 5f);
            }

        }



    }
}
