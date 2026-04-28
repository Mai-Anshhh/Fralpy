using System;
using UnityEngine;

public class audiomanagers1 : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clips")]
    public AudioClip background;
    public AudioClip jump;
    public AudioClip Point;
    public AudioClip die;

    public void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    internal void PlaySFX(AudioClip point)
    {
        throw new NotImplementedException();
    }
}
