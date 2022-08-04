using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xPos = 0;
    float moveAmount = 0;
    public float forwardMoveSpeed = 0.5f;
    public float horizontalMoveSpeed = 0.5f;
    public float maxMovePos = 1f;


    //bool isOnRight, isOnLeft, isSliding;
    //bool isOnMiddle = true;


    private void FixedUpdate()
    {
        GetMoveInput();
        Move();
    }


    private void GetMoveInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            xPos = Input.mousePosition.x;

        } else if (Input.GetMouseButton(0))
        {
            moveAmount = Input.mousePosition.x - xPos;
            xPos = Input.mousePosition.x;

        }else if (Input.GetMouseButtonUp(0))
        {
            moveAmount = 0;
            xPos = Input.mousePosition.x;
        }
    }

    void Move()
    {
        MoveRightLeft();
        Vector3 newPos = transform.position + transform.forward * Time.deltaTime * forwardMoveSpeed;
        transform.position = Vector3.Lerp(transform.position, newPos, 0.5f);

        //transform.position += transform.forward * Time.deltaTime * forwardMoveSpeed;
        //rigidbody.MovePosition(transform.position + Vector3.forward * Time.deltaTime * forwardMoveSpeed);
    }

    void MoveRightLeft()
    {
        Vector3 newPos = transform.position + new Vector3(moveAmount * horizontalMoveSpeed * Time.deltaTime, 0, 0);
        if(newPos.x < maxMovePos && newPos.x > -maxMovePos)
        {
            transform.position = Vector3.Lerp(transform.position, newPos, 0.5f);
        }
    }

    /*
    private void MoveByLine()
    {
        if(moveAmount > 400)
        {
            if (isOnLeft)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                isOnLeft = false;
                isOnMiddle = true;
                moveAmount = 0;

            }else if (isOnMiddle)
            {
                transform.position = new Vector3(1, transform.position.y, transform.position.z);
                isOnMiddle = false;
                isOnRight = true;
                moveAmount = 0;

            }
        }
        else if (moveAmount < -400)
        {
            if (isOnRight)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
                isOnRight = false;
                isOnMiddle = true;
                moveAmount = 0;

            }
            else if (isOnMiddle)
            {
                transform.position = new Vector3(-1, transform.position.y, transform.position.z);
                isOnLeft = true;
                isOnMiddle = false;
                moveAmount = 0;

            }

        }
    }
    */
}