using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour
{
    void Start()
    {
        // This line is there to tell me the x position of my object

        /* Hi there
         * This is two lines!
         * */ 
        Debug.Log(transform.position.x);


        if (transform.position.y <= 5f)
        {
            Debug.Log("Im about to hit the ground!");
        }
    }
}