using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public float force;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.AddForce(0, 0, force * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.AddForce(0, 0, -force * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.AddForce(force * Time.deltaTime, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.Force);
        }

        if (player.position.y <= -20)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}