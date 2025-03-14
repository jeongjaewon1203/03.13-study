using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;


    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        Vector3 dirction = new Vector3(moveX, moveY, 0).normalized;

        //Vector3 move = dirction * speed * Time.deltaTime;

        

        //Vector3 A = new Vector3(1, 2, 3);
        //Vector3 B = new Vector3(3, 1, -2);
        //Vector3 C = A + B;
        //Vector3 D = A - B;

        float magnitude = Mathf.Sqrt(dirction.x * dirction.x + dirction.y * dirction.y + dirction.z * dirction.z);

        Vector3 normalized = new Vector3(dirction.x / magnitude, dirction.y / magnitude, dirction.z / magnitude);

        Vector3 move = normalized * speed * Time.deltaTime;

        transform.position += move;

        //transform.position = new Vector3(1, 2, 3);
    }
}
