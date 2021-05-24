using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource audio;
    //public AudioClip startgame;

    public void gameStart()
    {
        SceneManager.LoadScene("SpaceInvaders");
    }

    public void audioPlay()
    {
        audio.GetComponent<AudioSource>();
        audio.Play();
    }
}
