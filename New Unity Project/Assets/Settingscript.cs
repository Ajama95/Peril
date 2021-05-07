using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settingscript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void Setvolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
}
