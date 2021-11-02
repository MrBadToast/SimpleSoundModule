using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCode : MonoBehaviour
{
    private SimpleSoundModule soundModule;

    private void Awake()
    {
        soundModule = GetComponent<SimpleSoundModule>();
    }
    public void OnNormalClicked()
    {
        soundModule.Play("Click");
    }

    public void OnRandomPitchClicked()
    {
        soundModule.Play("Click_Pitch");
    }
    public void OnRandomVolumeClicked()
    {
        soundModule.Play("Click_Volume");
    }

    public void OnFadeInClicked()
    {
        soundModule.FadeIn("music",3.0f);
    }

    public void OnFadeOutClicked()
    {
        soundModule.FadeOut(3.0f);
    }

    public void OnStopMusicClicked()
    {
        soundModule.Stop();
    }

    public void OnPlayRandomClicked()
    {
        soundModule.Play("Click_Random");
    }
}
