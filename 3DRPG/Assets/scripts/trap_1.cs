using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_1 : MonoBehaviour
{
    private Transform trapa;
    public float hight = 7f;//距離
    void Start()
    {
        trapa = this.transform.Find("trap1");
    }

    
    void Update()
    {
        transform.position = new Vector3(14.5f + Mathf.PingPong(Time.time * 10, hight),
                                         transform.position.y,
                                         transform.position.z);
    }
}
