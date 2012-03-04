using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float cameraSpeed;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 delta = new Vector3(cameraSpeed * Time.deltaTime, 0.0f, 0.0f);
		transform.Translate(delta);
	}
	
}
