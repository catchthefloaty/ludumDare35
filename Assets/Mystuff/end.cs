using UnityEngine;
using System.Collections;

public class end : MonoBehaviour {
    public Score s;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider col) {
        if (col.tag == "Player") {
            if (PlayerPrefs.HasKey("best"))
            {
                if (s.curTime < PlayerPrefs.GetFloat("best")) {
                    PlayerPrefs.SetFloat("best",s.curTime);
                }
                PlayerPrefs.SetFloat("lastTime", s.curTime);
            }
            else {
                PlayerPrefs.SetFloat("best", s.curTime);
                PlayerPrefs.SetFloat("lastTime", s.curTime);
            }


            Application.LoadLevel("end");
        }
    }
}
