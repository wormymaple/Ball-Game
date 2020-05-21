using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public AudioSource Click;
    public bool On;
    public Animator animator;
    public float Delay;
    public float DelayTillOff;
    public bool CountDelay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Down", On);
        if (CountDelay == true)
        {
            Delay += Time.deltaTime;
            if (Delay >= DelayTillOff)
            {
                Delay = 0;
                On = false;
                CountDelay = false;
            }
        }
    }
    public void PlayClick()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        On = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball Character")
        {
            CountDelay = true;
            Delay = 0;
        }
    }
}
