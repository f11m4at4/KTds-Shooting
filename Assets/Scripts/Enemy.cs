using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Ʒ��� ��� �̵��ϰ�ʹ�.
// Ÿ�������� �̵��ϰ�ʹ�.
// �ʿ�Ӽ� : Ÿ��
// �¾ �� �ѹ� ������ ���� �� �� �������� ��� �̵��ϰ� �ʹ�.
public class Enemy : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 10;
    // �ʿ�Ӽ� : Ÿ��
    public Transform target;

    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // 1. ������ �ʿ� direction = target - me
        dir = target.position - transform.position;
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        // Ÿ�������� �̵��ϰ�ʹ�.

        // 2. �̵��ϰ�ʹ�.
        // �Ʒ��� ��� �̵��ϰ�ʹ�.
        // P = P0 + vt
        Vector3 P0 = transform.position;
        Vector3 vt = dir * speed * Time.deltaTime;
        Vector3 P = P0 + vt;
        transform.position = P;
    }
}
