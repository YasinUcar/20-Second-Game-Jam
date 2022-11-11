using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerController : MonoBehaviour
{

    [SerializeField] float uygulanacakGuc;
    [SerializeField] GameObject[] particles;
    [SerializeField] ParticleSystem[] particleSystems;

    float ItmeAcisiE = 120, ItmeAcisiW = 60, ItmeAcısıDefault = 0;
    private void Start()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particleSystems[i] = particles[i].GetComponent<ParticleSystem>();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("a"))
        {
            particles[0].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.GetComponent<Rigidbody>().AddForce(new Vector3(0, 90, 0)* uygulanacakGuc, ForceMode.Impulse);

        }
        if (Input.GetKey("d"))
        {
            particles[1].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 90, 0) * uygulanacakGuc, ForceMode.Impulse);

        }
        if (Input.GetKey("e"))
        {
            particles[2].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, ItmeAcisiE, 0) * uygulanacakGuc, ForceMode.Impulse);

        }
        if (Input.GetKey("w"))
        {
            particles[3].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.GetComponent<Rigidbody>().AddForce(new Vector3(0, ItmeAcisiW, 0)* uygulanacakGuc, ForceMode.Impulse);

        }
    }
}
