using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public float maxRotation;
    public float minRotation;

    public float speed;
    private bool facingmax = true;

    void Update()
    {
        Debug.Log(transform.eulerAngles.z);
        if (transform.eulerAngles.z > maxRotation && facingmax)
            facingmax = false;
        if (transform.eulerAngles.z < minRotation && !facingmax)
            facingmax = true;
        
        if (facingmax)
            transform.Rotate(0, 0, Time.deltaTime * speed);

        else if (!facingmax)
            transform.Rotate(0, 0, Time.deltaTime * -speed);

    }
}
