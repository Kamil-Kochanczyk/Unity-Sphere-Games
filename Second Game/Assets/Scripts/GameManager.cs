using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public Text levelCompleted;
	public Rigidbody player;
	public bool levelWon = false;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex != 0)
		{
			SceneManager.LoadScene(0);
		}
	}

	public void GameOver()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void WinLevel()
	{
		levelWon = true;
		levelCompleted.enabled = true;
		player.constraints = RigidbodyConstraints.FreezeAll;
		Invoke("ReturnToMenu", 3f);
	}

	private void ReturnToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}