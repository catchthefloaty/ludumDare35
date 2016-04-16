using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player") {
            col.GetComponent<player>().respawnPos = transform.GetChild(0).position;
        }

    }
}
