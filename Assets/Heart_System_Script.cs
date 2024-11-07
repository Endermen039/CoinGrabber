using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_System_Script : MonoBehaviour
{
    public GameObject[] hearts;
    public int shields;

    // Update is called once per frame
    void Update()
    {
        if(shields < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if(shields < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if(shields < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }
    public void TakeDamage()
    {
        shields -= 1;
    }
}
