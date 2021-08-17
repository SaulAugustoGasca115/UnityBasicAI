using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWaypoint : MonoBehaviour
{

    [Header("Test Waypoints")]
    public GameObject[] points;
    int CurrentPoint = 0;

    public float speed = 2.5f;
    public float acurracy = 0.5f;
    public float rotationSpeed = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("testpoint");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        PathMove();
    }

    void PathMove()
    {
        if(points.Length != 0)
        {
            Vector3 lookAtGoal = new Vector3(points[CurrentPoint].transform.position.x,this.transform.position.y,points[CurrentPoint].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction),rotationSpeed * Time.deltaTime);
           


            if(direction.magnitude < acurracy)
            {
                CurrentPoint++;

                if(CurrentPoint >= points.Length)
                {
                    CurrentPoint = 0;
                }

                //this.transform.Translate(direction.normalized * speed *Time.deltaTime);
                //this.transform.position += new Vector3(transform.position.x,transform.position.y,transform.position.z * speed * Time.deltaTime);
            }

            this.transform.Translate(0,0,speed * Time.deltaTime);
        }
        else
        {
            return;
        }


    }
}
