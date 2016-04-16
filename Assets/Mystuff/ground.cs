using UnityEngine;
using System.Collections;

public class ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    void OnCollisionExit(Collision col) {
        if (col.gameObject.tag == "Player") {
            col.gameObject.GetComponent<player>().grounded = false;
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!col.gameObject.GetComponent<AudioSource>().isPlaying && col.gameObject.GetComponent<player>().grounded == false) { 
            col.gameObject.GetComponent<AudioSource>().Play();
            }

            col.gameObject.GetComponent<player>().grounded = true;

            
        }
    }

}
