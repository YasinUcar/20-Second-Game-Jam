using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerA : MonoBehaviour
{
    public GameObject effectObje;
    ParticleSystem ParticleSystem;
    private void Start()
    {
        ParticleSystem= effectObje.GetComponent<ParticleSystem>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("a"))
        {
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            ParticleSystem.Play();
        }
    }
}
