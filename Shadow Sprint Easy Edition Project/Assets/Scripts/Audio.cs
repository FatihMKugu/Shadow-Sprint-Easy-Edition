using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public Slider volumeSlider; // UI Slider nesnesi
    public Text volumeText; // UI Text nesnesi

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // PlayerPrefs sadece uygulama ba�lat�ld���nda y�klenmeli
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        volumeSlider.value = savedVolume;
        audioSource.volume = savedVolume;

        audioSource.Play();

        // Dinleyici yaln�zca bir kez eklenmeli
        volumeSlider.onValueChanged.AddListener(delegate { SetVolume(); });

        // Ba�lang��ta bir kez metni g�ncelleyin
        UpdateVolumeText();
       
    }
    private void Update()
    {
        UpdateVolume();
    }

    void UpdateVolume()
    {
        audioSource.volume = volumeSlider.value;
    }
    void SetVolume()
    {
        UpdateVolumeText();

        // PlayerPrefs sadece ses seviyesi de�i�ti�inde g�ncellenmeli
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
        PlayerPrefs.Save();
    }
    void UpdateVolumeText()
    {
        volumeText.text = Mathf.Round(volumeSlider.value * 100f) + "%";
    }
}