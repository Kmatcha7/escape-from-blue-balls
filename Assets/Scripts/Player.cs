using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody myRigidbody;
    public float speed = 20f;
   

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 velocity = myRigidbody.velocity;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector3(speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector3(-speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.velocity = new Vector3(0f, 0f, speed);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody.velocity = new Vector3(0f, 0f, -speed);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("GAMEOVER");
            SceneManager.LoadScene("gameover");
        }
    }
}
