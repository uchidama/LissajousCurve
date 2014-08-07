using UnityEngine;
using System.Collections;

public class LissajousLineControl : MonoBehaviour {

	LineRenderer line;
	int lineDrawNum = 30;

	public Color32 startColor;
	public Color32 endColor;

	// Use this for initialization
	void Start () {

		line = gameObject.AddComponent<LineRenderer> ();
		line.useWorldSpace = false;

		//line.material.color = Color.green;
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.SetWidth (0.05f, 0.05f);
		line.SetVertexCount (lineDrawNum);
		line.SetColors (startColor, endColor);

	}

	void drawLine()
	{
		float A = 9.0f;
		float B = 9.0f;
		float a = 1.0f;
		float b = 2.0f;
		float def = 0.02f;
		float t = (Time.time)*Mathf.PI/180*80;

		for (int i = 0; i < lineDrawNum; ++i) {
			line.SetPosition (i, new Vector3 (A * Mathf.Cos (a * t), B * Mathf.Sin (b * t - Mathf.PI / 4), 0));
			t += def;
		}

	}
		
	// Update is called once per frame
	void Update () {
		drawLine ();
	}
}
