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

        // PlayerPrefs sadece uygulama baþlatýldýðýnda yüklenmeli
        float savedVolume = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
        volumeSlider.value = savedVolume;
        audioSource.volume = savedVolume;

        audioSource.Play();

        // Dinleyici yalnýzca bir kez eklenmeli
        volumeSlider.onValueChanged.AddListener(delegate { SetVolume(); });

        // Baþlangýçta bir kez metni güncelleyin
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

        // PlayerPrefs sadece ses seviyesi deðiþtiðinde güncellenmeli
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
        PlayerPrefs.Save();
    }
    void UpdateVolumeText()
    {
        volumeText.text = Mathf.Round(volumeSlider.value * 100f) + "%";
    }
}