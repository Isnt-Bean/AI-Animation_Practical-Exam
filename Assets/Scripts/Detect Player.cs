using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public bool searchForPlayer = false;
    
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Zombie")
        {
            searchForPlayer = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Zombie")
        {
            searchForPlayer = false;
        }
    }
}
