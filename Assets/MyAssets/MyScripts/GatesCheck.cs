using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatesCheck : MonoBehaviour
{
    [SerializeField] private AudioClip _ad;
    [SerializeField] private AudioSource _as;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            _as.PlayOneShot(_ad);
    }
}
