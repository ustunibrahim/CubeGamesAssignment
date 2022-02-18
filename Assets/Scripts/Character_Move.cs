using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{
    public float speed =-0.5f, verticalMove;
    Vector3 firstPos, endPos;
 

    private void Start()
    {
        Time.timeScale = 0;
        gameObject.GetComponent<Animator>().SetBool("stop", true);
    }

    void Update()
    {
       
        
        transform.Translate(speed * Time.deltaTime, 0, 5 * Time.deltaTime);
        gameObject.GetComponent<Animator>().SetBool("Running", true);
        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
            Time.timeScale = 1;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float differenceX= endPos.x-firstPos.x;
            transform.Translate(differenceX * Time.deltaTime * verticalMove, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;

        }

    }
   
    
}

