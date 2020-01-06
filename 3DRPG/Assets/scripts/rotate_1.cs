using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_1 : MonoBehaviour
{
    public Transform trans;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        trans.Rotate(0, 10, 0);
    }
}
