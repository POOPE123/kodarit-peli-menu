using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public FadeControl fadeControl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fadeControl.gameObject.SetActive(true);
        fadeControl.fadeOut();
    }
}