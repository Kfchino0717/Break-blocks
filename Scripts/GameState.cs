using UnityEngine;

public class GameState : MonoBehaviour
{
    private int hitOneBrickPoint = 23;
    private int score = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);//��U�@�Ӷ��q������]���|����
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
