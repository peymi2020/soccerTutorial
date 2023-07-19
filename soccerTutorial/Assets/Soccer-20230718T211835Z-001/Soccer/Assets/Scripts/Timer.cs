using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
  public float timeTarget=120;
  public TextMeshProUGUI timer;
    void Update()
    {
      timeTarget -=Time.deltaTime;
      timer.text = timeTarget.ToString();
      if(timeTarget<=0)
        timer.text="0";
    }
}
