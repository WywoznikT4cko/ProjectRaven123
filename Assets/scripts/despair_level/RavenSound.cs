using System.Collections;
using System.Collections.Generic;
using UnityEngine; public class InputManagerRaven : MonoBehaviour
{
    private void Start()
    {
    AudioManager.Instance.Play(AudioManager.SoundType.Raven);
    }
}