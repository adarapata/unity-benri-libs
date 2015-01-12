using UnityEngine;
using System;
using System.Collections;

public class SoundList : ScriptableObject {
    private AudioClip[] audioList = new AudioClip[0];

    public AudioClip this[int i]
    {
        get { return audioList [i]; }
        set { audioList [i] = value; }
    }

    void OnEnable()
    {
        int enumLength = Enum.GetNames (typeof(GameSound)).Length;
        if (audioList.Length == enumLength)
            return;

        AudioClip[] swap = audioList.Clone() as AudioClip[];
        audioList = new AudioClip[enumLength];
        for (int i = 0; i < audioList.Length; i++) {
            audioList [i] = swap [i];
        }
    }
}
