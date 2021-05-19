using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private Fader fader;

    // Start is called before the first frame update
    void Start() => fader = FindObjectOfType<Fader>();

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            // This is passing a reference to the LoadScene function to be run
            // when the fade is complete
            fader.FadeDown(LoadScene);
        }
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
