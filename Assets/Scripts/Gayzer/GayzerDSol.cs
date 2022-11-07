using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerDSol : MonoBehaviour
{
    [SerializeField] GameObject effectObje;
    [SerializeField] float uygulanacakGuc;
    [SerializeField] float ItmeAcisi;


    ParticleSystem ParticleSystem;
    private void Start()
    {
        ParticleSystem = effectObje.GetComponent<ParticleSystem>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(ItmeAcisi, 90, 0) * uygulanacakGuc, ForceMode.Force);
            ParticleSystem.Play();
        }
    }
}
