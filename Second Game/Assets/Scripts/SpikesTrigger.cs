using UnityEngine;

public class SpikesTrigger : MonoBehaviour
{
	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "Player")
		{
			FindObjectOfType<GameManager>().GameOver();
		}
	}
}