using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
    public Transform target;
    public Vector3 dist = new Vector3(0, -5, 2);
    public float  smoothFactor = 1;
    public float speed = 2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 wantedPos = target.position - dist;


        transform.position = Vector3.Lerp(transform.position, wantedPos, Time.deltaTime * smoothFactor * speed);
    }
}
