using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sometime_turn : MonoBehaviour
{
    public float angle = 90;

    public int max_count = 100;

    int count = 0;

    void Start()
    {
        count = 0;    
    }

    void FixedUpdate()
    {
        count = count + 1;
        if(count == max_count)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
