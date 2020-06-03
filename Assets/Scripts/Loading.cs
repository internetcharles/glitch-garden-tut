using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    [SerializeField] AudioSource audioData = default;
    private void Awake()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

}
