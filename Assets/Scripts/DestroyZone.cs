using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // �ε��� ��ü�� �����ϰ� �ʹ�.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
