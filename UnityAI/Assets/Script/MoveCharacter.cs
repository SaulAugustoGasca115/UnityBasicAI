using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

    public Vector3 goal = new Vector3(5,0,4);
    public float speed = 0.1f;

    private int rows = 5;
    private int coeficient = 1;

    public GameObject coef;
    public GameObject blackPrefab;
    GameObject coe;
    Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        //goal = goal * 0.01f;
        //PascalTriangle();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }


    void PascalTriangle()
    {
        for(int i = 0;i<rows;i++)
        {
            //for(int space=1;space<=rows-i;space++)
            //{
            //    //Debug.Log(" ");
            //    Instantiate(blackPrefab, new Vector3(i,i,0), Quaternion.identity);
            //}


            //for(int space=1;space<=rows-i;space++)
            //{
            //    Instantiate(blackPrefab, new Vector3(space, space, 0), Quaternion.identity);
            //}


            /*for(int j=0;j<=i;j++)
            {
                if(j == 0 || i == 0)
                {
                    coeficient = 1;
                }
                else
                {
                    coeficient = coeficient * (i - j + 1) / j;
                }

                //Debug.Log(coeficient + " ");
                Instantiate(coef,transform.position,Quaternion.identity);
            } */

            //Debug.Log(" ");

            //for(int j=1;j<=i; j++)
            //{
            //    coeficient = coeficient * (i - j + 1) / j;


            //    Instantiate(coef, new Vector3(j, j + coeficient, 0), Quaternion.identity);


            //}

            

            for (int space=1;space<=rows-i; space++)
            {
                //offset = new Vector3(j,i+0.5f,0);
                Instantiate(blackPrefab, new Vector3(space, i+0.5f, 0), Quaternion.identity);
            }

            for(int j=0;j<=i;j++)
            {
                //if(j == 0 || i == 0)
                //{
                //    Instantiate(coef, new Vector3(j, i + 0.5f, 0), Quaternion.identity);
                //}

                Instantiate(coef, new Vector3(j, i + 0.5f, 0), Quaternion.identity);
            }


        }
    }
}
