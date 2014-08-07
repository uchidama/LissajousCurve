using UnityEngine;
using System.Collections;

public class AppManage : MonoBehaviour {

	public GameObject ball;	/// <LassajousBallControl>

	// Use this for initialization
	void Start () {

		Vector3[] pos = {
			new Vector3(0, 0, 0),
			new Vector3(7, 7, 5),
			new Vector3(-7, 7, 5),

		};

		Color32[] startColor = {
			new Color32 (0, 10, 0, 255),
			new Color32 (10, 0, 0, 255),
			new Color32 (0, 0, 10, 255),
		};

		Color32[] endColor = {
			new Color32 (0, 255, 0, 255),
			new Color32 (255, 0, 0, 255),
			new Color32 (0, 0, 255, 255),
		};

		for(int i=0;i < startColor.Length; ++i){
			GameObject b = (GameObject)Instantiate (ball, transform.position, Quaternion.identity);
			b.transform.position = pos[i];

			LissajousBallControl l = b.GetComponent<LissajousBallControl>();
			l.startColor = startColor[i];
			l.endColor = endColor[i];
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
