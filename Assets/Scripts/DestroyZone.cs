using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // 부딪힌 물체를 제거하고 싶다.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
