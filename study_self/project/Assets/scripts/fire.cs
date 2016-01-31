using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	// 
	int speed = 5;
	public Transform newObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate(x, 0, z);
		//if (z != 0 )
		//	print ("csharp");

		if (Input.GetButtonDown ("Fire1")) {
			Transform t = Instantiate(newObject, transform.position, transform.rotation) as Transform;

			Vector3 dir = transform.TransformDirection(Vector3.forward);

			t.rigidbody.AddForce(dir * 2800);
		}
	}
}
