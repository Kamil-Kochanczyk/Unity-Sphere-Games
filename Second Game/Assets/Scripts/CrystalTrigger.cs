using UnityEngine;

public class CrystalTrigger : MonoBehaviour
{
	private static CrystalTrigger[] crystals;
	public GameObject particles;

	public static int TotalCrystals { get; private set; }
	public static int CollectedCrystals { get; private set; }

	void Start()
	{
		crystals = FindObjectsOfType<CrystalTrigger>();
		TotalCrystals = crystals.Length;
		CollectedCrystals = 0;
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Player")
		{
			CollectedCrystals++;
			Destroy(gameObject);
			Instantiate(particles, transform.position, Quaternion.identity);

			if (CollectedCrystals == TotalCrystals)
			{
				FindObjectOfType<GameManager>().WinLevel();
			}
		}
	}
}