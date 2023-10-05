using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float Xposition = 0f;
    public float Yposition = 0f;
    public float Xspeed;
    public float Yspeed;


    // Start is called before the first frame update
    void Start()
    {
        Xspeed = 5f;
        Yspeed = 5f;
        transform.position = new Vector3(Xposition, Yposition, 0);


    }

    // Update is called once per frame
    void Update()
    {

        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Horizontalwall"))
        {
            Debug.Log(" Horizontal Colliders entering Collision ");
            Yspeed = Yspeed * -1;
        }



        if (collision.gameObject.CompareTag("Verticalwall"))
        {
            Debug.Log(" Vertical Colliders entering Collision ");
            Xspeed = Xspeed * -1;
        }
        if (collision.gameObject.CompareTag("Paddle1"))
            Yspeed = Yspeed * -1;
        {

            if (collision.gameObject.CompareTag("Paddle2"));
            Xspeed = Xspeed * -1;

        }

    }
    }