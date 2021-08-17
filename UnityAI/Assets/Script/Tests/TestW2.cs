using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestW2 : MonoBehaviour
{

    public float Speed = 2.5f;
    public float RotationSpeed = 0.8f;
    public GameObject[] points;
    int CurentPoint = 0;
    public float Acurracy = 0.5f; 

    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("testpoint2");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //if(this.transform.position.x <= 3.0f && this.transform.position.z <= 3.0f)
        //{
        //    this.transform.Translate(new Vector3(3 * Speed * Time.deltaTime, 0, 3 * Speed * Time.deltaTime));
        //}

        Movement();
       
    }

    void Movement()
    {
        if (points.Length != 0)
        {
            Vector3 lookAtGoal = new Vector3(points[CurentPoint].transform.position.x, this.transform.position.y, points[CurentPoint].transform.position.z);

            Vector3 direction = lookAtGoal - this.transform.position;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), RotationSpeed * Time.deltaTime);



            if (direction.magnitude < Acurracy)
            {
                CurentPoint++;

                if (CurentPoint >= points.Length)
                {
                    CurentPoint = 0;
                }

                //this.transform.Translate(direction.normalized * speed *Time.deltaTime);
                //this.transform.position += new Vector3(transform.position.x,transform.position.y,transform.position.z * speed * Time.deltaTime);
            }

            this.transform.Translate(0, 0, Speed * Time.deltaTime);
        }
        else
        {
            return;
        }

    }


}
