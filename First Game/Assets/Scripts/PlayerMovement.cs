using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody player;
    public Transform ground;
    public float forwardForce = 8000f;
    public float sidewaysForce = 55f;
    public bool isOnTheGround;

    void Start()
    {
        player.mass = 5f;
    }

    void FixedUpdate()
    {
        player.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow) && isOnTheGround)
        {
            player.AddForce(0, 25f, 0, ForceMode.Impulse);
            isOnTheGround = false;
        }

        if (player.position.y < ground.position.y)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}