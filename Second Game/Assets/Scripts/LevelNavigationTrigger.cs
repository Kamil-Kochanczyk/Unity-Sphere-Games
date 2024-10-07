using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNavigationTrigger : MonoBehaviour
{
	public TextMesh text;

	void OnTriggerEnter(Collider collider)
	{
		if (collider.name == "Player")
		{
			string sceneName = text.text;

			switch (sceneName)
			{
				case "Level 1":
				case "Level 2":
					SceneManager.LoadScene(sceneName);
					break;
				case "Quit":
					Application.Quit();
					break;
			}
		}
	}
}