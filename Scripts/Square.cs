using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //Vector2為沒有z軸的向量
    private Vector2 mousePos;
    private float limitX, limitY;//約束範圍
    [SerializeField] private float screenWidth = 17f, screenHeigth = 12f;
    [SerializeField] private float square = 2f;
    void Update()
    {
        //轉換向量座標
        mousePos = new Vector2(Input.mousePosition.x / Screen.width * screenWidth,
                    Input.mousePosition.y / Screen.height * screenHeigth);
        limitX = Mathf.Clamp(mousePos.x, -8.5f + square/2, 8 - square / 4);//16是Unity的單位(網格)//左右範圍
        //limitY = Mathf.Clamp(mousePos.y, -6 + 0.25f, 6 - 0.25f);//12是Unity的單位
        limitY = transform.position.y;
        mousePos = new Vector2(limitX, limitY);//
        transform.position = mousePos;//進行物件跟隨
    }
    //private void OnGUI()
    //{               //顯示在螢幕的位置
    //    GUI.Label(new Rect(10, 10, 300, 20), Input.mousePosition.ToString());//顯示並取得滑鼠向量並轉換字串
    //    GUI.Label(new Rect(10, 30, 300, 20), "Screen Width " + Screen.width +
    //        "Screen Height " + Screen.height);
    //}
}
