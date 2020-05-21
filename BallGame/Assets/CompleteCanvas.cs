using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteCanvas : MonoBehaviour
{
    public int ThisLevelIsWhatLevel;
    public string[] Levels = { "Level1", "Level2", "Level3" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(Levels[ThisLevelIsWhatLevel]);
    }

}
