using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class BlueLight : MonoBehaviour
{
    public BlueLightCondition Condition;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Condition != null)
        {
            if (Condition.Yes == true)
            {
                GetComponent<Light2D>().enabled = true;
                GetComponent<Animator>().enabled = true;
            }
            else
            {
                GetComponent<Light2D>().enabled = false;
                GetComponent<Animator>().enabled = false;
            }
        }
        else
        {
            GetComponent<Light2D>().enabled = true;
            GetComponent<Animator>().enabled = true;
        }
    }
    
}
