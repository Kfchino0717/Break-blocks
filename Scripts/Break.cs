using UnityEngine;

public class Break : MonoBehaviour
{
    [SerializeField] AudioClip ac;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindFirstObjectByType<Level>().AddOneBrick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //gameObject.SetActive(false);//讓面板取消勾選
        Destroy(gameObject);//摧毀物件與秒數延遲(該物件,秒數)
        //GetComponent<AudioSource>().Play();
        AudioSource.PlayClipAtPoint(ac,Camera.main.transform.position);
        //取得攝影機座標撥放音檔
        FindFirstObjectByType<Level>().HitOneBrick();
        FindFirstObjectByType<GameState>().AddSocre();
    }
}
