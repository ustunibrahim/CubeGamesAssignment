using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    public static int score;

    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = score.ToString();   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "xbot")
        {
            score += 10;
            Destroy(gameObject);
        }
    }
}
