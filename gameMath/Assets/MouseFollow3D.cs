using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
public class MouseFollow3D : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 targetPosition;
    void Update()
    {
        //마우스 왼쪽 버튼 클릭

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
            }
        }

        Vector3 dirction = (targetPosition - transform.position).normalized;
        Vector3 move = dirction * speed * Time.deltaTime;

        transform.position += move;
    }
}