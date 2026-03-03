using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f;

    private Image fadeObject;
    private Color originalcolor;

    private Coroutine coroutine;

    void Awake()
    {
        fadeObject = GetComponent<Image>();
        if (fadeObject == null)
        {
            Debug.Log("Fade object not found");
            return;
        }

        Color originalColor = fadeObject.color;
    }

    private void StartFade(float targetAlpha)
    {
        if (coroutine != null)
        {
            StopCoroutine(FadeRoutine(targetAlpha));
        }
        coroutine = StartCoroutine(FadeRoutine(targetAlpha));
    }

    private IEnumerator FadeRoutine(float targetAlpha)
    {
        float time = 0f;
        float startAlpha = fadeObject.color.a;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;

            Color colorChange = fadeObject.color;
            float t = time / fadeDuration;
            colorChange.a  = Mathf.Lerp(startAlpha, targetAlpha, t);
            fadeObject.color = colorChange;

            yield return null;
        }

        Color final =fadeObject.color;
        final.a = targetAlpha;
        fadeObject.color = final;
    }

}