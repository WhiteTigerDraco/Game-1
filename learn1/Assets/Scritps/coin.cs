using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
    Playercontrol a;
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
        Debug.Log("tril");
        Destroy(gameObject);
      // a.score+=1;
        Debug.Log("score: " );
    }
}
