using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barrier : MonoBehaviour
{
    Text text;
    
    public static int live=3;
    void Start()
    {
        text = GetComponent<Text>();
    }

   
    void Update()
    {
        text.text = live.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "xbot")
        {
            live -= 1;    
        }
        if (live == 0)
        {
            live = 3;
            SceneManager.LoadScene("Game Over");
        }
    }
}
