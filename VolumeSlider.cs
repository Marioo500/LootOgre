using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider volumen;

    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();

        }
        else
        {
            Load();
        }
    }

    public void CambiarVolumen()
    {
        AudioListener.volume = volumen.value;
    }

    private void Load()
    {
        volumen.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumen.value);
    }
}
