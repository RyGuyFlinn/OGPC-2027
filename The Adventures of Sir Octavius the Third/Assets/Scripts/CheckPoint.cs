using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerManager>().lastCheckPoint = transform;
        }
    }
}
