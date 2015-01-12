using UnityEngine;
using UnityEditor;
using System.Collections;
using System;

[CustomEditor (typeof(SoundList))]
public class SoundListEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI ()
    {
        string[] names = Enum.GetNames (typeof(GameSound));
        var soundList = target as SoundList;
        for (int i = 0; i < names.Length; i++) {
            soundList [i] = EditorGUILayout.ObjectField (names [i], soundList [i], typeof(AudioClip)) as AudioClip;
        }
    }
}
