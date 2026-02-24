using UnityEngine;
using UnityEngine.UI;

public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f;

    private Image fadeObject;
    private Color originalcolor;

    void Awake()
    {
        fadeObject = GetComponent<Image>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
