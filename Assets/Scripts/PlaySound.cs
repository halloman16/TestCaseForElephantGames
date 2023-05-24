using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    private void OnMouseDown()
    {
        _audio.Play();
    }
}
