using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{

    public Transform goal;
    public float speed = 0.5f;
    float accuracy = 1.0f;
    public float rotationSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,this.transform.position.y,goal.position.z);


        Vector3 direction = lookAtGoal - this.transform.position;

        //this.transform.LookAt(lookAtGoal);

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction),rotationSpeed * Time.deltaTime);

        //if(Vector3.Distance(this.transform.position,lookAtGoal) > accuracy)
        //{
        //    this.transform.Translate(0, 0, speed * Time.deltaTime);
        //}


        
        
    }
}
