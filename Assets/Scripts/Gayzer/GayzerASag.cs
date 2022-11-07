using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerASag : MonoBehaviour
{
    [SerializeField] GameObject effectObje;
    [SerializeField] float uygulanacakGuc;
    ParticleSystem ParticleSystem;
    [SerializeField] float ItmeAcisi;
    private void Start()
    {
        ParticleSystem = effectObje.GetComponent<ParticleSystem>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("w"))
        {
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0, uygulanacakGuc, 0), ForceMode.Impulse);
            ParticleSystem.Play();
        }
    }
}
