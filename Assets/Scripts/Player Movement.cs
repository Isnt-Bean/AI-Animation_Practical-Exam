using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Get input values
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Movement direction
        Vector3 direction = new Vector3(-1* vertical, 0f, horizontal);

        // Apply movement
        transform.Translate(direction * speed * Time.deltaTime);
    }
}