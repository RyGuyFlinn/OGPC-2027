using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Color playerColor;

    void Update()
    {
        playerColor = GetComponent<SpriteRenderer>().color;
        Debug.Log(MoustacheData.moustacheIndex);
    }
}
