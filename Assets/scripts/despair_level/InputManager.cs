using System.Collections;
using System.Collections.Generic;
using UnityEngine; public class InputManager : MonoBehaviour
{
    private void Start()
    {
    AudioManager.Instance.ChangeMusic(AudioManager.SoundType.Music);
    }
}