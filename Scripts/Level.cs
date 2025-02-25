using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField]private int brickCount = 0;
    private int currentTime;
    [SerializeField] float gameSpeed = 1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = ((int)Time.time);
        ChangeGameSpeed();
    }

    private void ChangeGameSpeed()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameSpeed += 0.1f;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameSpeed -= 0.1f;
        }
        Time.timeScale = gameSpeed;
    }

    public void AddOneBrick()
    {
        brickCount++;
    }
    public void HitOneBrick() 
    {
        brickCount--;
        if (brickCount <= 0)
        {
            FindFirstObjectByType<Play>().nextScene();
        }
    }
    public int GetTime()
    {
        return currentTime;
    }
}
