using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    public int keysCollected = 0;
    public Rigidbody doorObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (keysCollected == transform.childCount) {
            doorObject.isKinematic = false;
            this.enabled = false;
        }
	}
}
