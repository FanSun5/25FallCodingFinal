using UnityEngine;

public class MovementLocker : MonoBehaviour
{
    public MonoBehaviour movementScript;
    public Rigidbody2D rb2D;

    public void Lock() {
        if (movementScript) movementScript.enabled = false;
        if (rb2D) rb2D.linearVelocity = Vector2.zero;
    }

    public void Unlock() {
        if (movementScript) movementScript.enabled = true;
    }
}
