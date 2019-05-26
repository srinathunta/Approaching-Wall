using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public float ShrinkSpeed = 3f;
    public int scorevalue;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * ShrinkSpeed * Time.deltaTime;
        if (transform.localScale.x <= 0.05f)
        {
            Score.scoreValue += 1;
            Destroy(gameObject);
            
        }
    }
}
