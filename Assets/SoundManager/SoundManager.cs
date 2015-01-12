using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour
{
    public SoundList soundList;

    public void Play(GameSound soundName)
    {
        GameObject sound = new GameObject (soundName.ToString ());
        sound.AddComponent<AudioSource> ();
        sound.audio.clip = soundList [(int)soundName];
        sound.audio.Play ();
        Destroy (sound, 3F);
    }       
}
