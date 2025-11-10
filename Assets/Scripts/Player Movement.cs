using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Movement direction
        Vector3 direction = new Vector3(-1* vertical, 0f, horizontal);

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}