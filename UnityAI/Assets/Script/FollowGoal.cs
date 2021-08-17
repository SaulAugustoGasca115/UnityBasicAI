using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGoal : MonoBehaviour
{
    [Header("Follow Goal Attributes")]
    public Transform goal;
    public float speed = 2.0f;
    public float accuracy = 1.0f;
    public float rotationSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,this.transform.position.y,goal.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;

        this.transform.rotation = Quaternion.Lerp(this.transform.rotation,Quaternion.LookRotation(direction),rotationSpeed * Time.deltaTime);

        this.transform.Translate(0,0,speed * Time.deltaTime);
    }
}
