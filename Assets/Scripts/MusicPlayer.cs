using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{

    public static MusicPlayer instance;
    int currentSong = 0;
    AudioSource audioSource;
    public AudioClip[] clipNames;
    public Text musicName;
    private bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartAudio();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad0)){
            StopAudio();
        }
        if(Input.GetKeyDown(KeyCode.Keypad1)){
            StartAudio();
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            StartAudio(-1);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            StartAudio(1);
        }
    }

    public void StartAudio(int changeMusic = 0)
    {
        currentSong += changeMusic;
        if(currentSong >= clipNames.Length)
        {
            currentSong = 0;
        }
        else if(currentSong < 0)
        {
            currentSong = clipNames.Length - 1;
        }

        if(audioSource.isPlaying && changeMusic == 0)
        {
            return;
        }

        if(stop)
        {
            stop = false;
        }
        audioSource.clip = clipNames[currentSong];
        musicName.text = audioSource.clip.name;
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.Stop();
        stop = true;
    }
}