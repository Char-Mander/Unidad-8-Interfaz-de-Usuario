using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
	private bool gamePause { get; set; }
    public GameObject pausePanel;

    public GameObject soundController;
    public Slider sliVolume;
    public Dropdown themeSelector;

    public List<AudioClip> themes = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ApplyPause();
        }
    }

    void ApplyPause() {
        gamePause = !gamePause;
        pausePanel.SetActive(gamePause);
        if (gamePause)
        {
            Time.timeScale = 0.001f;
        }
        else {
            Time.timeScale = 1;
        }

    }

    public void MusicOnOff(bool value) {
        if (value)
        {
            
            soundController.GetComponent<AudioSource>().Play();
        }
        else {
            soundController.GetComponent<AudioSource>().Pause();
        }
        
    }

    public void ChangeVolume() {
        soundController.GetComponent<AudioSource>().volume = sliVolume.value;
    }

    public void ChangeTheme() {
        soundController.GetComponent<AudioSource>().clip = themes[themeSelector.value];
        soundController.GetComponent<AudioSource>().Play();
    }

}
