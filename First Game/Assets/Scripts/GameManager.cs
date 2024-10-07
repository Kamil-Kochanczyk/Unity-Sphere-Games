using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool gameOver = false;
	public PlayerMovement movement;
	public GameObject levelCompleted;

	public void CompleteLevel()
	{
		levelCompleted.SetActive(true);
	}

	public void EndGame()
	{
		gameOver = true;
		movement.enabled = false;

		Invoke("Restart", 3f);
	}

	private void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}