using UnityEngine;
using System.Collections;

public class deathbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider col) {
        if (col.tag == "Player") {
            col.transform.position = col.gameObject.GetComponent<player>().respawnPos;
        }


        if (col.tag == "key") {
            col.transform.position = col.GetComponent<key>().respawn;
        }

    }
}
