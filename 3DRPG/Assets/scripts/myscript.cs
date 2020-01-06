using UnityEngine;

public class myscript : MonoBehaviour
{
    protected Joystick joystick;
    protected joybutton joybutton;
    
    void Start() //開始後執行一次
    {
        joystick = FindObjectOfType<Joystick>();  //根據元件的類別直接搜尋，如果是Script腳本就直接輸入對應名稱
        joybutton = FindObjectOfType<joybutton>();
    }
  
    void Update() //每秒60次
    {
        var rigidbody = GetComponent<Rigidbody>();  //GetComponent組件擷取  

        rigidbody.velocity = new Vector3(joystick.Horizontal * 10f,   //rigidbody.velocity是給與物體一個向量值，這個值就是物體當下的速度
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 10f);
    }
}
