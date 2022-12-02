using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer General;
    public AudioMixerGroup SFX, Musica;
    public AudioSource musica1;
    public AudioSource SonidoCaida,AudioDisparo,AgarrarHoja;
    public Slider masterSlider, musicaSlider, efectosslider;

    public static AudioManager instance;

    private void Awake()
    {

        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        masterSlider.value = ItemManager.current.generalvol;
        musicaSlider.value = ItemManager.current.musicavol;
        efectosslider.value = ItemManager.current.efecctsvol;

        masterSlider.minValue = -80;
        masterSlider.maxValue = 10;

        efectosslider.minValue = -80;
        efectosslider.maxValue = 10;

        musicaSlider.minValue = -80;
        musicaSlider.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MasterVolume();
        EfectosVolume();
        MusicaVolume();
    }

    public void MasterVolume()
    {
        General.SetFloat("General", masterSlider.value);
    }
    public void EfectosVolume()
    {
        General.SetFloat("Efectos", efectosslider.value);
    }
    public void MusicaVolume()
    {
        General.SetFloat("Musica", musicaSlider.value);
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
    public void StopAudio(AudioSource audio)
    {
        audio.Stop();
    }
}
