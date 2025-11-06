using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player
    public float smoothSpeed = 0.125f; // Speed of the camera’s smoothing
    public Vector3 offset; // Offset from the player
    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset; // Desired position of the camera
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smooth transition
        transform.position = smoothedPosition; // Apply the new position
    }
}