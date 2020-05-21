using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Switch[] Switches;
    public int SwitchesOn;
    public float Delay;
    public float MaxDelay;
    public Switch Controller;
    public bool Open;
    public Animator animator;
    public bool ProximityDoor;
    public Transform CharacterPos;
    public float DistanceToPlayer;
    public float MaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        CharacterPos = GameObject.Find("Ball Character").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ProximityDoor == false)
        {
            if (Switches.Length <= 0)
            {
                if (Controller.On == true)
                {
                    Open = true;
                }
                if (Controller.On == false && Open == true)
                {
                    Delay += Time.deltaTime;
                }
                if (Controller.On == false && Delay >= MaxDelay)
                {
                    Delay = 0;
                    Open = false;
                }
            }
            else
            {
                Debug.Log("This");
                SwitchesOn = 0;
                for (int i = 0; i < Switches.Length; i++)
                {
                    if (Switches[i].On == true)
                    {
                        SwitchesOn += 1;
                    }
                }
                Debug.Log("Switches On: " + SwitchesOn);
                if (SwitchesOn >= Switches.Length)
                {
                    Open = true;
                }
                else
                {
                    Open = false;
                }
            }
        }
        else
        {
            DistanceToPlayer = Vector2.Distance(transform.position, CharacterPos.position);
            if (DistanceToPlayer <= MaxDistance)
            {
                Open = true;
            }
            else
            {
                Open = false;
            }
        }
        animator.SetBool("Down", Open);
    }
    public void Woosh()
    {
        GetComponent<AudioSource>().Play();
    }
}
