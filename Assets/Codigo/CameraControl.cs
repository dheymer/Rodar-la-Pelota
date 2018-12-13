using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
    public GameObject objPlayer;
    private Vector3 relativePosition;

	// Use this for initialization
	void Start () {
        relativePosition = transform.position - objPlayer.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = objPlayer.transform.position + relativePosition;
	}
}
