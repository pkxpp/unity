using UnityEngine;
using System.Collections;

public class mouse : MonoBehaviour {
    // var
    bool tril1 = false;
    bool tril2 = false;
    Color srcColor;

	// Use this for initialization
	void Start () {
        // original color
        srcColor = GetComponent<Renderer>().material.color;
        // colour
        GameObject.Find("Spotlight").GetComponent<Light>().intensity = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (tril2)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 200);
            
            if (GameObject.Find("Spotlight").GetComponent<Light>().intensity < 2)
            {
                GameObject.Find("Spotlight").GetComponent<Light>().intensity += 0.01f;
            }
        }
	}

    void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
        tril1 = true;
    }

    void OnMouseExit() {
        GetComponent<Renderer>().material.color = srcColor;
        tril1 = false;
    }

    void OnMouseDown() {
        if (tril1)
            tril2 = true;
    }
}
