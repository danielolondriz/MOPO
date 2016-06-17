using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public GameObject origin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Fire();
		}
	}
	void Fire()
	{
		RaycastHit hit;
		if (Physics.Raycast(origin.transform.position, origin.transform.forward, out hit))
		{
			if (hit.collider.tag == "pillar" ||hit.collider.tag == "Rpillar" )
			{
				print ("HIT:" + hit.collider.gameObject.name);
			}
		}
	}
}
