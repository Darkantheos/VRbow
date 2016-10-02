using UnityEngine;
using System.Collections;

public class BeltQuiver_position : MonoBehaviour {

	public Transform head;
	public float hauteur;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (head.position.x, head.position.y-hauteur, head.position.z);
	
	}
}
