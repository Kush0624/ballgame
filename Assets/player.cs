using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody ball;
    public float ballforce;
    public Text Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text="Score "+ball.position.z.ToString("0");
        ball.AddForce(0,0,ballforce);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            ball.AddForce (-ballforce,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ball.AddForce(ballforce, 0, 0);
        }
        if(ball.position.y<-2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }
}
