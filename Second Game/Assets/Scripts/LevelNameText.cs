using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNameText : MonoBehaviour
{
	public TextMesh levelText;

	void Start()
	{
		levelText.text = SceneManager.GetActiveScene().name;
	}
}