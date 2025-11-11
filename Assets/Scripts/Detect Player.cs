using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print(collision.gameObject.name);
        }
    }
}
