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
        //gameObject.SetActive(false);//�����O�����Ŀ�
        Destroy(gameObject);//�R������P��Ʃ���(�Ӫ���,���)
        //GetComponent<AudioSource>().Play();
        AudioSource.PlayClipAtPoint(ac,Camera.main.transform.position);
        //���o��v���y�м�����
        FindFirstObjectByType<Level>().HitOneBrick();
        FindFirstObjectByType<GameState>().AddSocre();
    }
}
