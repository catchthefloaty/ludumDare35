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
            col.gameObject.GetComponent<player>().grounded = true;
        }
    }

}
