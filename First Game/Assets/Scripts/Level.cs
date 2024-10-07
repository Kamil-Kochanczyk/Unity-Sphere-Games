using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
	public Text level;

	void Update()
	{
		level.text = SceneManager.GetActiveScene().name;
	}
}
