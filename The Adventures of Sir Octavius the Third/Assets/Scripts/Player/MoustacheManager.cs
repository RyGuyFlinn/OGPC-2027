using UnityEngine;
using UnityEngine.UI;

public class MoustacheData
{
    public static int moustacheIndex = 0;
}

public class MoustacheManager : MonoBehaviour
{
    public Animator animator;
    public Color selectionColor;
    public Image[] buttons;

    public void OnMoustache0ButtonPressed()
    {
        MoustacheData.moustacheIndex = 0;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[0].color = selectionColor;
    }
    public void OnMoustache1ButtonPressed()
    {
        MoustacheData.moustacheIndex = 1;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[1].color = selectionColor;
    }
    public void OnMoustache2ButtonPressed()
    {
        MoustacheData.moustacheIndex = 2;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[2].color = selectionColor;
    }
    public void OnMoustache3ButtonPressed()
    {
        MoustacheData.moustacheIndex = 3;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[3].color = selectionColor;
    }
    public void OnMoustache4ButtonPressed()
    {
        MoustacheData.moustacheIndex = 4;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[4].color = selectionColor;
    }
    public void OnMoustache5ButtonPressed()
    {
        MoustacheData.moustacheIndex = 5;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[5].color = selectionColor;
    }
    public void OnMoustache6ButtonPressed()
    {
        MoustacheData.moustacheIndex = 6;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[6].color = selectionColor;
    }
    public void OnMoustache7ButtonPressed()
    {
        MoustacheData.moustacheIndex = 7;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[7].color = selectionColor;
    }
    public void OnMoustache8ButtonPressed()
    {
        MoustacheData.moustacheIndex = 8;
        animator.SetBool("Visible", false);

        foreach(Image img in buttons)
        {
            img.color = Color.white;
        }
        buttons[8].color = selectionColor;
    }
}
