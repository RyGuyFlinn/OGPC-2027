using UnityEngine;

public class DoorScanner : MonoBehaviour
{
    public GameObject door;
    public Animator animator;
    public Color backgroundColor;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerManager>().playerColor != backgroundColor)
            {
                Debug.Log("Open Door");
                animator.SetBool("Open", true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("Open", false);
        }
    }
}
