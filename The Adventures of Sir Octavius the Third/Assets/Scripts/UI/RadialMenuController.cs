using UnityEngine;

public class RadialMenuController : MonoBehaviour
{
    public GameObject radialMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            radialMenu.SetActive(!radialMenu.activeSelf);
        }

        if (radialMenu.activeSelf)
        {
            Time.timeScale = 0.25f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
