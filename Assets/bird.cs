using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

	public GameObject panelGameOver;
    void OnCollisionEnter2D (Collision2D coll) {
        panelGameOver.SetActive (true);
    }
	public void fly() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 1f);
	}
}
