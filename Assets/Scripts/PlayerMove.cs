using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է��� �޾� �����¿�� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �̵��ӵ�
public class PlayerMove : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ������� �Է��� �޾� �����¿�� �̵��ϰ� �ʹ�.
        // 1. ������� �Է¿� ����
        float h = Input.GetAxis("Horizontal");// a, d, left, right
        float v = Input.GetAxis("Vertical"); // w, s, up, down
        // 2. �������ʿ�
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        // ũ�⸦ 1�� ����� �ʹ�.
        dir.Normalize();
        // 3. �̵��ϰ�ʹ�.
        // P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }
}
