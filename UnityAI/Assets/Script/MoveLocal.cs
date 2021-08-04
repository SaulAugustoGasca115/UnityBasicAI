using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocal : MonoBehaviour
{

    public Transform goal;
    public float speed = 0.5f;
    float accuracy = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,this.transform.position.y,goal.position.z);


        Vector3 direction = this.transform.position - lookAtGoal;

        this.transform.LookAt(lookAtGoal);

        if(direction.magnitude > accuracy)
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }


        
        
    }
}
