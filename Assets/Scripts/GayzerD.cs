using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerD : MonoBehaviour
{
    [SerializeField] GameObject effectObje2;
    ParticleSystem ParticleSystem;
    private void Start()
    {
        ParticleSystem = effectObje2.GetComponent<ParticleSystem>();

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("d") && other.gameObject.CompareTag("Halka"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            ParticleSystem.Play();
        }
    }

}
