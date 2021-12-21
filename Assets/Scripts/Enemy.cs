using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아래로 계속 이동하고싶다.
// 타겟쪽으로 이동하고싶다.
// 필요속성 : 타겟
// 태어날 때 한번 방향을 구한 후 그 방향으로 계속 이동하고 싶다.

// 다른 물체와 부딪히면 갸도 죽고 나도 죽고.
// 죽을 때 폭발효과를 발생시키고 싶다.
// 필요속성 : 폭발효과 공장
public class Enemy : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 10;
    // 필요속성 : 타겟
    public Transform target;

    Vector3 dir;
    // 필요속성 : 폭발효과 공장
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        // 시작할 때 타겟을 동적으로 찾아서 할당하자
        GameObject obj = GameObject.Find("Player");
        if (obj)
        {
            target = obj.transform;
        }
        // 만약 타겟이 null 이라면
        if (target == null)
        {
            // 방향은 그냥 아래로 설정하자
            dir = Vector3.down;
        }
        else
        {
            // 1. 방향이 필요 direction = target - me
            dir = target.position - transform.position;
            dir.Normalize();
        }
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

    // 다른 물체와 부딪히면 갸도 죽고 나도 죽고.
    // Enter, Stay, Exit
    private void OnCollisionEnter(Collision other)
    {
        // 폭발효과 발생시키고 싶다.
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        // 갸도 죽고
        Destroy(other.gameObject);
        // 나도 죽고
        Destroy(gameObject);
    }
}
