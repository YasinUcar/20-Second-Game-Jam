using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GayzerA : MonoBehaviour
{
    [SerializeField] GameObject effectObjeLeft;
    [SerializeField] GameObject effectObjeRight;
    ParticleSystem ParticleSystemLeft, ParticleSystemRight;

    private void Start()
    {
        ParticleSystemLeft = effectObjeLeft.GetComponent<ParticleSystem>();
        ParticleSystemRight = effectObjeRight.GetComponent<ParticleSystem>();

    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("a"))
        {
            if (other.gameObject.CompareTag("Halka"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            ParticleSystemLeft.Play();
        }
        if (Input.GetKey("d"))
        {
            if (other.gameObject.CompareTag("Halka"))
                other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            ParticleSystemRight.Play();
        }

    }
}
