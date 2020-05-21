using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenFlag : MonoBehaviour
{
    public float TimeCompleted;
    public Text TimeCompletedText;
    public Text TotalUTs;
    public GameObject EndCanvas;
    public bool CollectTime = true;
    public float TimeToLevel;
    public float TimeToLevelMax;

    // Start is called before the first frame update
    void Start()
    {
        TimeCompleted = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (CollectTime == true)
        {
            TimeCompleted += Time.deltaTime;
        }
    }
    public void LevelComplete()
    {
        Character.CanMove = false;
        CollectTime = false;
        EndCanvas.SetActive(true);
        TimeCompletedText.text = "Time: " + TimeCompleted;
        TotalUTs.text = "Total Upgrade Tokens: " + Character.TotalUT;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ball Character")
        {
            LevelComplete();
        }
        Debug.Log("The flag is detecting something");
    }
}
