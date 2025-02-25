using UnityEngine;
using UnityEngine.SceneManagement;

public class lossArea : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit the Trigger");
        SceneManager.LoadScene("GameOver");//³õ´º¦WºÙ
    }
}
