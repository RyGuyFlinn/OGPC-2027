using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator moustacheAnimator;

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnMoustacheButtonPressed()
    {
        moustacheAnimator.SetBool("Visible", true);
    }

    public void OnQuitButtonPressed()
    {

    }
}
