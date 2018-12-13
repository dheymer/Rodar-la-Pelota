using UnityEngine;
using System.Collections;

public class ItemRotation : MonoBehaviour {
    Vector3 rotacion = new Vector3(15, 30, 45);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotacion * Time.deltaTime);
	}
}
