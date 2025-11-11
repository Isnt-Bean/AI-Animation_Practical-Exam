using UnityEngine;

public class SwapWeapon : MonoBehaviour
{

    public GameObject Axe;

    public GameObject Sword;

    private Animator animator;
    
    private bool hasAxe = false;
    private bool hasSword = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Axe.SetActive(false);
        Sword.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && hasAxe)
        {
            Axe.SetActive(true);
            animator.SetBool("IsAttacking", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && hasSword)
        {
            Sword.SetActive(true);
            animator.SetBool("IsAttacking", true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Sword.SetActive(false);
            Axe.SetActive(false);
            animator.SetBool("IsAttacking", false);
        }
        
        
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("IsWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetBool("IsCrouching", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            animator.SetBool("IsCrouching", false);
        }
    }
    

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Axe")
        {
            Destroy(other.gameObject);
            print("Has Axe");
            hasAxe = true;
            Axe.SetActive(true);
            hasSword = false;
        }

        if (other.tag == "Sword")
        {
            Destroy(other.gameObject);
            print("Has Sword");
            hasSword = true;
            Sword.SetActive(true);
            hasAxe = false;
        }
    }
}
