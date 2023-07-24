using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSpray : MonoBehaviour
{
    [SerializeField] ParticleSystem snowSpray;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            snowSpray.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            snowSpray.Stop();
        }
    }

}
