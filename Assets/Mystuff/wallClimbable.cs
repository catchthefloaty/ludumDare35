using UnityEngine;
using System.Collections;

public class wallClimbable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnCollisionStay(Collision col) {
        if (col.gameObject.tag == "Player") {
            player temp = col.gameObject.GetComponent<player>();
            if (temp.form == 1) {
                if ( Mathf.Abs(Input.GetAxis("Horizontal")) > 0 || Mathf.Abs(Input.GetAxis("Vertical")) > 0)
                temp.GetComponent<Rigidbody>().AddForce(0,15,0);
            }




        }
    }
}
