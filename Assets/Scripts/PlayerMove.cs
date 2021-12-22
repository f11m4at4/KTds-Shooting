using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력을 받아 상하좌우로 이동하고 싶다.
// 필요속성 : 이동속도
public class PlayerMove : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 입력을 받아 상하좌우로 이동하고 싶다.
        // 1. 사용자의 입력에 따라
        
        float h = Input.GetAxis("Horizontal");// a, d, left, right
        float v = Input.GetAxis("Vertical"); // w, s, up, down
        // 2. 방향이필요
        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        // 크기를 1로 만들고 싶다.
        dir.Normalize();
        // 3. 이동하고싶다.
        // P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
        Vector3 pos = transform.position;
        // 특정 범위를 벗어나지 못하게 하고 싶다.
        if(pos.x < -8.35f)
        {
            pos.x = -8.35f;
        }
        if (pos.x > 8.35f)
        {
            pos.x = 8.35f;
        }
        transform.position = pos;
    }
}
