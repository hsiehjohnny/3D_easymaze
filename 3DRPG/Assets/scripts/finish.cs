using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    [Header("顯示")]
    public GameObject obj;
 
    private void OnTriggerEnter(Collider other)   //進入觸發
    {
        print(other.name);
        if (other.name == "player" )   //當進入的物件名稱為player時
        {

            obj.SetActive(true);      //設為可見
        }
    }
    private void OnTriggerExit(Collider other)  //離開觸發
    {
        if (other.name == "player")
        {
            obj.SetActive(false);
        }
    }
}
