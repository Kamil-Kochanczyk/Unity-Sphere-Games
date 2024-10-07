using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text score;

	void Update()
	{
		score.text = $"Crystals: {CrystalTrigger.CollectedCrystals}/{CrystalTrigger.TotalCrystals}";
	}
}