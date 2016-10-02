using UnityEngine;
using System.Collections;

public class BeltQuiver_position : MonoBehaviour {

	public GameObject Head;


	// Use this for initialization
	void Start () 
	{
		Head.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		Head.transform.position = transform.position;
	
	}
}
