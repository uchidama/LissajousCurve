using UnityEngine;
using System.Collections;

public class LissajousBallControl : MonoBehaviour {

	public GameObject line;

	public Color32 startColor;
	public Color32 endColor;

	// Use this for initialization
	void Start () {

		for(float angle = 0;angle < 360f; angle+=360/30){
			GameObject l = (GameObject)Instantiate (line, transform.position, Quaternion.AngleAxis(angle, Vector3.up));
			l.transform.parent = this.transform;

			LissajousLineControl lis = l.GetComponent<LissajousLineControl>();
			lis.startColor = this.startColor;
			lis.endColor = this.endColor;
		}

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.AngleAxis( Time.time* 60, Vector3.right);
		this.transform.rotation *= Quaternion.AngleAxis( Time.time* 60, Vector3.up);
	}

}
