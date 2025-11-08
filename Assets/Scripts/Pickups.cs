using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickups : MonoBehaviour
{
    public AudioSource pickupSource;

    void Start()
    {

        pickupSource = GameObject.Find("Pickup Sound").GetComponent<AudioSource>();

    }
   
    void Update ()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            pickupSource.Play ();
            Destroy(gameObject);
            ScoreManager.instance.AddPoint ();
        }
        
    }
}
