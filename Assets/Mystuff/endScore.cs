using UnityEngine;
using System.Collections;

public class endScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string minutes = Mathf.Floor(PlayerPrefs.GetFloat("lastTime") / 60).ToString("00");
        string seconds = (PlayerPrefs.GetFloat("lastTime") % 60).ToString("00");

        string minutes2 = Mathf.Floor(PlayerPrefs.GetFloat("best") / 60).ToString("00");
        string seconds2 = (PlayerPrefs.GetFloat("best") % 60).ToString("00");



        GetComponent<UnityEngine.UI.Text>().text = "This Time: "+ minutes +":"+seconds + "\n Best Time: " + minutes2 + ":" + seconds2 + "\n Press B to quit and Press A to Try Again";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("A") > 0) {
            Application.LoadLevel("test");
        }
        if (Input.GetAxis("B") > 0)
        {
            Application.Quit();
        }
    }
}
