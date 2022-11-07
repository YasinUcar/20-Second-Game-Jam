using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerController : MonoBehaviour
{

    [SerializeField] float uygulanacakGuc;
    [SerializeField] GameObject[] particles;
    [SerializeField] ParticleSystem[] particleSystems;

    float ItmeAcisiE = 120, ItmeAcisiD = 60, ItmeAcısıDefault = 0;
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
                other.GetComponent<Rigidbody>().AddForce(new Vector3(0, uygulanacakGuc, 0), ForceMode.Impulse);

        }
        if (Input.GetKey("d"))
        {
            particles[1].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(ItmeAcisiD, 90, 0) * uygulanacakGuc, ForceMode.Force);

        }
        if (Input.GetKey("e"))
        {
            particles[2].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(ItmeAcisiE, 90, 0) * uygulanacakGuc, ForceMode.Force);

        }
        if (Input.GetKey("w"))
        {
            particles[3].GetComponent<ParticleSystem>().Play();
            if (other.CompareTag("ring"))
                other.GetComponent<Rigidbody>().AddForce(new Vector3(0, uygulanacakGuc, 0), ForceMode.Impulse);

        }
    }
}
