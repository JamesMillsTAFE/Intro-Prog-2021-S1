using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void FadeCallback();

[RequireComponent(typeof(Image))]
public class Fader : MonoBehaviour
{
    [SerializeField] private Color solid = Color.black;
    [SerializeField] private Color faded = Color.clear;
    [SerializeField, Range(.1f, 10f)] private float fadeTime = 1f;

    private Image image;

    // Start is called before the first frame update
    void Start() => image = gameObject.GetComponent<Image>();

    public void FadeDown(FadeCallback _callback = null)
    {
        StartCoroutine(FadeToSolid(_callback));
    }

    private IEnumerator FadeToSolid(FadeCallback _callback = null)
    {
        // To store the time we are currently at for the lerp function
        float currentTime = 0;

        // Loop until currentTime exceeds fadeTime
        while(currentTime < fadeTime)
        {
            // Add the deltaTime to the currentTime and get the lerp factor
            currentTime += Time.deltaTime;
            float factor = Mathf.Clamp01(currentTime / fadeTime);

            // Update the image colour by the interpolated value of solid and clear
            image.color = Color.Lerp(faded, solid, factor);

            // Wait until the next frame
            yield return null;
        }

        // force the image colour to be the solid colour in case of floating point
        // check errors
        image.color = solid;

        // Run the callback for the fade being completed
        _callback?.Invoke();
    }
}
