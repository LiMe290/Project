using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private float timeLeft;
    [SerializeField] private GameObject cube;
    [SerializeField] private InputController ic;
    private void Awake() {
        timeLeft += ic.Time;
    }
    private void Update() 
    {
        Debug.Log(timeLeft);
        if ( timeLeft < 0 )
        {
            Instantiate(cube,transform.position,Quaternion.identity);
            timeLeft += ic.Time;
        } 
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }
}
