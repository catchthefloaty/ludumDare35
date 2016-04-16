using UnityEngine;
using System.Collections;

public class keyHole : MonoBehaviour {
    bool used = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionEnter(Collision col) {
        if (!used) {
            
            if (col.gameObject.tag == "key") {
                
                used = true;
                col.gameObject.transform.parent = transform.GetChild(0);
                col.gameObject.transform.localPosition = Vector3.zero;
                col.gameObject.GetComponent<Rigidbody>().isKinematic = true;

                col.gameObject.GetComponent<pickup>().used = true;
                transform.parent.GetComponent<door>().keysCollected += 1;
            }
        }
    }
}
