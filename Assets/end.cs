using UnityEngine;
using TMPro;
public class end : MonoBehaviour
{
    public TMP_Text t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void Finish(){
        print("hi3");
        t.text = "Oxygen Restored!";
        t.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
