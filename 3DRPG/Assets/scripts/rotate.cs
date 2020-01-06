using UnityEngine;
public class rotate : MonoBehaviour
{
    public Transform trans;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        trans.Rotate(0, 5, 0);
    }
}
