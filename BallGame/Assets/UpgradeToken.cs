using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class UpgradeToken : MonoBehaviour
{
    private AudioSource Plop;
    // Start is called before the first frame update
    void Start()
    {
        Plop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball Character")
        {
            Plop.Play();
            Character.TotalUT += 1;
            Destroy(gameObject.GetComponent<Renderer>());
            Destroy(gameObject.GetComponent<Light2D>());
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
    }
}
