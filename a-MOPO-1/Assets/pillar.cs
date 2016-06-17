using UnityEngine;
using System.Collections;

public class pillar : MonoBehaviour {
	public GameObject origin;
	public GameObject reflection;
	public GameObject pillare;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*RaycastHit hit;
		if (Physics.Raycast(origin.transform.position, origin.transform.forward, out hit))
		{
			if (hit.collider.tag == "laser")
			{
				print ("HELLO:" + hit.collider.gameObject.name);
			}
		}*/
		RaycastHit hit;
		if (Physics.Raycast (origin.transform.position,origin.transform.forward, out hit)) {
			if (origin.active == true) {
				if (hit.collider.tag == "Rpillar" && (hit.collider.name == pillare.transform.name)) {
					print ("HELLO:" + hit.collider.gameObject.name);
					reflection.active = true;
				} else {
					reflection.active = false;
				}
			}else {
				reflection.active = false;
			}

			/*switch(hit.transform.gameObject.tag)
			{
			case "Rpillar":
				//Output message
				//reflection.active = true;
				print("player detected");
				reflection.active = false;
				break;
			}*/

		}
		else {
			reflection.active = false;
		}
	}
}
