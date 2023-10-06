using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Vector3 TSpehre;
    private Vector3 TCube;
    private int speed;
    private int distance;
    private void Awake() {
        speed = GameObject.FindGameObjectWithTag("InputController").GetComponent<InputController>().Speed;
        distance = GameObject.FindGameObjectWithTag("InputController").GetComponent<InputController>().Distance;
    }
    private void Update() 
    {
        transform.Translate(new Vector3(0,0,1f) * speed * Time.deltaTime);

        TSpehre = GameObject.FindGameObjectWithTag("Sphere").GetComponent<Transform>().position;
        TCube = gameObject.GetComponent<Transform>().position;

        if(Vector3.Distance(TSpehre,TCube) > distance)
        {
            Destroy(gameObject);
        }
    }
}
