using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public float smoothingSpeed;
    public Vector3 tweak;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + tweak;
        Vector3 smoothingPosition = Vector3.Lerp(transform.position, desiredPosition, smoothingSpeed * Time.deltaTime);
        transform.position = smoothingPosition;

        transform.LookAt(player);
    }
}