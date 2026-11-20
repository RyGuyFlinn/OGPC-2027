using UnityEngine;

public class PlayerArtManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite moustache0;
    public Sprite moustache1;
    public Sprite moustache2;
    public Sprite moustache3;
    public Sprite moustache4;
    public Sprite moustache5;
    public Sprite moustache6;
    public Sprite moustache7;
    public Sprite moustache8;

    void Start()
    {
        if (MoustacheData.moustacheIndex == 0)
            spriteRenderer.sprite = null;
        if (MoustacheData.moustacheIndex == 1)
            spriteRenderer.sprite = moustache1;
        if (MoustacheData.moustacheIndex == 2)
            spriteRenderer.sprite = moustache2;
        if (MoustacheData.moustacheIndex == 3)
            spriteRenderer.sprite = moustache3;
        if (MoustacheData.moustacheIndex == 4)
            spriteRenderer.sprite = moustache4;
        if (MoustacheData.moustacheIndex == 5)
            spriteRenderer.sprite = moustache5;
        if (MoustacheData.moustacheIndex == 6)
            spriteRenderer.sprite = moustache6;
        if (MoustacheData.moustacheIndex == 7)
            spriteRenderer.sprite = moustache7;
        if (MoustacheData.moustacheIndex == 8)
            spriteRenderer.sprite = moustache8;
    }
}
