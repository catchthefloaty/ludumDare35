using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public float curTime = 0;
    UnityEngine.UI.Text t;
	// Use this for initialization
	void Start () {
        t = GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {
        curTime += Time.deltaTime;
        string minutes = Mathf.Floor(curTime / 60).ToString("00");
        string seconds = (curTime % 60).ToString("00");


        t.text = "Time: " + minutes + ":" + seconds + "    ";

	}
}
