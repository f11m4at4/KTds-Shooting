using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아래로 계속 이동하고싶다.
// 타겟쪽으로 이동하고싶다.
// 필요속성 : 타겟
// 태어날 때 한번 방향을 구한 후 그 방향으로 계속 이동하고 싶다.
public class Enemy : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 10;
    // 필요속성 : 타겟
    public Transform target;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // 1. 방향이 필요 direction = target - me
        dir = target.position - transform.position;
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        // 타겟쪽으로 이동하고싶다.

        // 2. 이동하고싶다.
        // 아래로 계속 이동하고싶다.
        // P = P0 + vt
        Vector3 P0 = transform.position;
        Vector3 vt = dir * speed * Time.deltaTime;
        Vector3 P = P0 + vt;
        transform.position = P;
    }
}
