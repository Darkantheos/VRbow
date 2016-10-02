using UnityEngine;
using System.Collections;

public class Destroy_arrow : MonoBehaviour {

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "destroyable") 
		{
			Destroy (collision.gameObject);

			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
