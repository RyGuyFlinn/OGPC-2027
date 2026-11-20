using UnityEngine;

public class Tentacle : MonoBehaviour
{
    public Transform hingePosition;

    void Update()
    {
        GetComponent<Rigidbody2D>().MovePosition(hingePosition.position);
    }
}
