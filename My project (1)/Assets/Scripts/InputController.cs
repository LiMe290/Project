using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputSpeed;
    [SerializeField] private TMP_InputField inputDistance;
    [SerializeField] private TMP_InputField inputTime;

    public int Speed;
    public int Distance;
    public int Time;

    private void Update() 
    {
        Speed = Convert.ToInt32(inputSpeed.text);
        Distance = Convert.ToInt32(inputDistance.text);
        Time = Convert.ToInt32(inputTime.text);
    }
}
