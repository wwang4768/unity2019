using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    public Button stop;
     // Start is called before the first frame update
     void Start()
     {
         Button btn = stop.GetComponent<Button>();
         btn.onClick.AddListener(ExitOnClick);

     }


     void ExitOnClick()
     {
         Application.Quit();
     }
     
}

