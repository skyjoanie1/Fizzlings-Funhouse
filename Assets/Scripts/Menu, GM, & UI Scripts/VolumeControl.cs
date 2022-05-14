using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer mixer;


    public void SetMaster(float sliderValue)
    {

        mixer.SetFloat("Master Volume", Mathf.Log10(sliderValue) * 20);

    }

    public void SetMusic(float sliderValue)
    {

        mixer.SetFloat("Music Volume", Mathf.Log10(sliderValue) * 20);

    }

    public void SetSFX(float sliderValue)
    {

        mixer.SetFloat("SFX Volume", Mathf.Log10(sliderValue) * 20);

    }


}
