using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour {
    float currentMusicTime;
    AudioSource music;

    public static MainMenuMusic mainMenuMusic;
	// Use this for initialization
	void Start () {
        if (mainMenuMusic == null)
        {
            mainMenuMusic = this;
        } else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
        music = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        currentMusicTime = music.time;
	}

    private void OnLevelWasLoaded(int level)
    {
        //Destroy menu music if playing game
        if (level == 2)
        {
            Destroy(this.gameObject);
        }
    }
}
