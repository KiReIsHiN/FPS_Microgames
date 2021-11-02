using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lovyshka : MonoBehaviour
{
    [SerializeField] private AudioClip _ad;
     AudioSource _as;

    private void Start()
    {
        _as = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            _as.PlayOneShot(_ad);
    }
}
