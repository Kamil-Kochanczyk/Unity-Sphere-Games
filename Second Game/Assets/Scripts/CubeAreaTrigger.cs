using UnityEngine;

public class CubeAreaTrigger : MonoBehaviour
{
	public SphereCollider crystal;
	public GameObject outerCrystal;
	public GameObject innerCrystal;

	void Start()
	{
		crystal.enabled = false;
		outerCrystal.GetComponent<MeshRenderer>().enabled = false;
		innerCrystal.GetComponent<MeshRenderer>().enabled = false;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Cube")
		{
			crystal.enabled = true;
			outerCrystal.GetComponent<MeshRenderer>().enabled = true;
			innerCrystal.GetComponent<MeshRenderer>().enabled = true;
		}
	}
}