using UnityEngine;
using UnityEngine.UI;

public class red_vignette_overlay_logic : MonoBehaviour
{
    public Image imageOverlay;
    public float fadeDuration = 1.0f; // Change this to 0.5f for a faster fade out
    private bool isTriggered = false;
    private bool isFading = false;

    private void Start()
    {
        // Ensure the overlay is initially hidden
        imageOverlay.CrossFadeAlpha(0f, 0f, false);

    }

    private void Update()
    {
        // You can replace this with your trigger condition
        // For example, check for a key press, mouse click, or any other input event.
        if (RespawnPoint.overlaytrigger == 1)
        {
            if (!isTriggered && !isFading)
            {
                // Show and fade in the overlay
                ShowOverlay();
            }
        }
        else
        {
            // Hide and fade out the overlay
            HideOverlay();
        }
    }

    private void ShowOverlay()
    {
        isTriggered = true;
        isFading = true;

        // Set the overlay to fully transparent before fading in
        imageOverlay.CrossFadeAlpha(0f, 0f, false);

        // Fade in the overlay
        imageOverlay.CrossFadeAlpha(1f, fadeDuration, false);

        // Delay to allow fading to complete before setting isFading to false
        StartCoroutine(DisableFading());
    }

    private void HideOverlay()
    {
        isTriggered = false;

        // If the overlay is currently fading in, stop the fade
        if (isFading)
        {
            imageOverlay.CrossFadeAlpha(0f, 0f, false);
            StopAllCoroutines();
            isFading = false;
        }
        else
        {
            // Fade out the overlay
            imageOverlay.CrossFadeAlpha(0f, fadeDuration, false);
        }
    }

    private System.Collections.IEnumerator DisableFading()
    {
        yield return new WaitForSeconds(fadeDuration);
        isFading = false;
    }
}
