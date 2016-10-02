using UnityEngine;
using System.Collections;

public class teleport_arrow : MonoBehaviour {

	public GameObject Player;
	public GameObject plateform;
	public float place;
	public GameObject spawn;




	void OnCollisionEnter (Collision collision)
	{
		ContactPoint contact = collision.contacts [0];



		Player = GameObject.Find ("[CameraRig]");

		if (collision.gameObject.tag == "teleportable_space") 
		
		{
			Player.transform.position = transform.position;
		}

		if (collision.gameObject.tag == "plateformable") 
		{
			
			{
				Vector3 pos = contact.point;
				Quaternion rot = Quaternion.LookRotation (contact.normal);
				Instantiate (plateform, pos, rot);
				Destroy (gameObject);
			}

		}

		if (collision.gameObject.tag == "plateform") 
		{
			
				
			Player.transform.position = spawn.transform.position;
			Player.transform.rotation = spawn.transform.rotation;


			Destroy (gameObject);
		}

		else 
		{
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
