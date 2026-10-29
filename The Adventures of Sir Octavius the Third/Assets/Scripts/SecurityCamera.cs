using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    public float maxRotation;
    public float minRotation;

    public Color backgroundColor;

    public float speed;
    private bool facingmax = true;
    private float checkrange = 5;

    void Update()
    {
        if (facingmax && anglecorrect(Mathf.Abs(transform.eulerAngles.z - maxRotation % 360)) <= checkrange)
            facingmax = false;
        else if (!facingmax && anglecorrect(Mathf.Abs(transform.eulerAngles.z - minRotation % 360)) <= checkrange)
            facingmax = true;
        
        if (facingmax)
            transform.Rotate(0, 0, Time.deltaTime * speed);

        else if (!facingmax)
            transform.Rotate(0, 0, Time.deltaTime * -speed);

    }

    float anglecorrect(float angle)
    {
        if (angle % 360 > 180)
        {
            return 360 - angle % 360;
        }

        return angle % 360;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player");
        {
            if (other.gameObject.GetComponent<PlayerManager>().playerColor != backgroundColor)
            {
                Debug.Log("Player Caught!!!");
            }
        }
    }
}
