using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	// 
	int speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate(x, 0, z);
		if (z != 0 )
			print ("csharp");
	}
}
