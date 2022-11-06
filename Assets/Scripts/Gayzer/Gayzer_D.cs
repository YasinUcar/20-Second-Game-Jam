using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gayzer_D : MonoBehaviour
{
    [SerializeField] GameObject effectObje;
    ParticleSystem ParticleSystem;
    private void Start()
    {
        ParticleSystem = effectObje.GetComponent<ParticleSystem>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("d"))
        {
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 6, 0), ForceMode.Impulse);
            ParticleSystem.Play();
        }
    }
}
