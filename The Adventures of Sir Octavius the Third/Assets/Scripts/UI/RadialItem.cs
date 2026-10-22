using UnityEngine;
using UnityEngine.UI;

public class RadialItem : MonoBehaviour
{
    Image img;
    
    public Color color;

    public GameObject[] playerParts;

    void Start()
    {
        img=GetComponent<Image>();
        img.alphaHitTestMinimumThreshold=0.5f;
        
    }

    public void OnButtonPressed()
    {
        Debug.Log("Color Changed" + color.ToString());
        foreach (GameObject part in playerParts)
        {
            part.GetComponent<SpriteRenderer>().color = color;
        }
    }
}
