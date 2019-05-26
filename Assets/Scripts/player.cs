using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public menu Menu;
    public Spawner spawner;
    public Text gameover;
    private bool restart;
    public float movespeed = 600f;
    float movement = 0f;
    public AudioSource GO;
    public GameObject Player;
    void Start()
    {
        gameover.text = "";
        restart = false;
        
        

        

    }
    void Update()
    {
        
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -movespeed);
    }
 
   void OnTriggerEnter2D(Collider2D collision)
   {
        Menu.menuV();
        restart = true;
        spawner.EndGame();
        GO.Play();
        //ball.GetComponent<Rigidbody2D>();
        gameover.text = "GAME OVER";
        if (Score.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            gameover.text = "CONGRATULATIONS\n\tGAME OVER";
        }

        Score.scoreValue -= 1;
    }
    
}
