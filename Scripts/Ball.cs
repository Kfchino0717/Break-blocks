using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Square pl; // 想去計算距離的物體(繫結)
    [SerializeField] Vector2 LaunchPower = new Vector2(0f, 10f);

    [SerializeField]AudioClip[] ac; 
    private Vector3 offset; // 距離
    private bool isLaunch = false; // 判定發射狀態

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - pl.transform.position; // 求得兩物件向量差
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunch)//非發射狀態
        {
            transform.position = pl.transform.position + offset;//進行跟隨
        }
        if (UnityEngine.Input.GetMouseButton(0))
        {
            isLaunch = true;
            LaunchBall(); // 發射事件
        }
    }

    private void LaunchBall()
    {
        // 使用 Rigidbody2D 並設置 2D 速度 (Vector2)
        GetComponent<Rigidbody2D>().linearVelocity = LaunchPower; // 發射
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int randomClipNumber = Random.Range(0,ac.Length);
        GetComponent<AudioSource>().PlayOneShot(ac[randomClipNumber]);//播放音效1
    }
}
