using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCkeckpoint : MonoBehaviour
{
    static public Vector2 Checkpoint;
    public Transform Ball;
    // Start is called before the first frame update
    void Start()
    {
        Checkpoint = new Vector2(0, 0);
        Ball = GameObject.Find("Ball Character").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EstablishCheckpoint()
    {
        if (Checkpoint != new Vector2(0, 0))
        {
            Ball.position = Checkpoint;
        }
        
    }
}
