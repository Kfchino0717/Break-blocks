using UnityEngine;
using TMPro;
public class TimeDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = FindAnyObjectByType<Level>().GetTime().ToString();
    }
}
