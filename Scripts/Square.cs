using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //Vector2���S��z�b���V�q
    private Vector2 mousePos;
    private float limitX, limitY;//�����d��
    [SerializeField] private float screenWidth = 17f, screenHeigth = 12f;
    [SerializeField] private float square = 2f;
    void Update()
    {
        //�ഫ�V�q�y��
        mousePos = new Vector2(Input.mousePosition.x / Screen.width * screenWidth,
                    Input.mousePosition.y / Screen.height * screenHeigth);
        limitX = Mathf.Clamp(mousePos.x, -8.5f + square/2, 8 - square / 4);//16�OUnity�����(����)//���k�d��
        //limitY = Mathf.Clamp(mousePos.y, -6 + 0.25f, 6 - 0.25f);//12�OUnity�����
        limitY = transform.position.y;
        mousePos = new Vector2(limitX, limitY);//
        transform.position = mousePos;//�i�檫����H
    }
    //private void OnGUI()
    //{               //��ܦb�ù�����m
    //    GUI.Label(new Rect(10, 10, 300, 20), Input.mousePosition.ToString());//��ܨè��o�ƹ��V�q���ഫ�r��
    //    GUI.Label(new Rect(10, 30, 300, 20), "Screen Width " + Screen.width +
    //        "Screen Height " + Screen.height);
    //}
}
