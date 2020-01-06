using UnityEngine;
using UnityEngine.EventSystems;

public class joybutton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    protected bool Pressed;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
