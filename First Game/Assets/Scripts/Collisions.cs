using UnityEngine;

public class Collisions : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Ground")
		{
			FindObjectOfType<PlayerMovement>().isOnTheGround = true;
		}
		if (collision.collider.tag == "Obstacle")
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}