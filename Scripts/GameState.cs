using UnityEngine;

public class GameState : MonoBehaviour
{
    private int hitOneBrickPoint = 23;
    private int score = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);//到下一個階段此物件也不會消失
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddSocre()
    {
        score += hitOneBrickPoint;
        //Debug.Log(score);
    }
    public int GetScore()
    {
        return score;
    }
}
