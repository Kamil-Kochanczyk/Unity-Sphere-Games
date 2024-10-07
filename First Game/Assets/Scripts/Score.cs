using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform player;
	public Text score;
	public GameManager gameManager;

	void Update()
	{
		if (gameManager.gameOver)
		{
			score.text = "Game over! Try again!\nScore: " + (player.position.z / 10).ToString("0");
		}
		else
		{
			score.text = (player.position.z / 10).ToString("0");
		}
	}
}