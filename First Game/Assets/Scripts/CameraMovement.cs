using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 tweak;

    void Update()
    {
        transform.position = player.position + tweak;
    }
}