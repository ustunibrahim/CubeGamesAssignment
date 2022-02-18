using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject xbot;
    Vector3 space;
    void Start()
    {
        space = transform.position - xbot.transform.position;
    }


    void Update()
    {
        transform.position = xbot.transform.position + space;
    }
}
