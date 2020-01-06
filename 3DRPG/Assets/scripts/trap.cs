using UnityEngine;

public class trap : MonoBehaviour
{
    private Transform trapa;   //每個在場景上的物件都有
    public float hight = 7f;//距離
    public float starpoint = 14.5f; //起點
    void Start()
    {
        trapa = this.transform.Find("trap");  //跟據transform來抓取"trap"物件
    }

    void Update()
    {
        transform.position = new Vector3(starpoint + Mathf.PingPong(Time.time * 5, hight),  //x位置    Mathf.PingPong(Time.time * 5, hight)是來回位移的程式，Time.time(通常為0)到hight(長度)，*5是對其進行加速
                                         transform.position.y,                              //y 
                                         transform.position.z);                             //z
    }
}
