using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Color playerColor;

    public Transform lastCheckPoint;

    void Update()
    {
        playerColor = GetComponent<SpriteRenderer>().color;
    }

    public void Death()
    {
        Debug.Log("Player Die");
        transform.position = lastCheckPoint.position;
    }
}
