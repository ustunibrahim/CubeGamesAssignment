using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
   
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            
            gameObject.GetComponent<Animator>().SetBool("finish", true);
            Score.score += 100;
        }
        if (other.gameObject.name == "Over")
        {
            Barrier.live = 3;
            SceneManager.LoadScene("Victory");

        }
        

    }
}

