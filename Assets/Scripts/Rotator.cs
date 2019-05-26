using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.scoreValue > 5) {
            transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
        }
        
    }
    
}
