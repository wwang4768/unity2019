using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetCount : MonoBehaviour
{

  public int TargetNum;
    private int TargetNow;
  public Slider TargetLeft;
  public PlayerController r;

    void Awake()
        {
             TargetLeft = GetComponent<Slider>();
             TargetNow = TargetNum;
        TargetLeft.maxValue = TargetNum;
        TargetLeft.minValue = 0;
        TargetLeft.value = TargetNow;
             }
    private void Update()
    {
        TargetNow = TargetNum - r.count;
        TargetLeft.value = TargetNow;
    }

 

   
}

