using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigid : MonoBehaviour {

    private float speed;

	// Use this for initialization
	void Start () {
        speed = 3;
	}
	
	// Update is called once per frame
	void Update () {
        float axisx = Input.GetAxis("Horizontal");
        float axisy = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(axisx, axisy) * Time.deltaTime * speed);
    }
}
