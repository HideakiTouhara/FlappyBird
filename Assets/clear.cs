using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour {

	public GameObject panel;
	void OnCollisionEnter2D(Collision2D coll) {
		panel.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
