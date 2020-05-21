using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetainTargetPos : MonoBehaviour
{
    public Transform Target;
    public Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position + Offset;
    }
}
