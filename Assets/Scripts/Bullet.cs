using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 필요속성 : 이동속도
public class Bullet : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 위로 계속 이동하고싶다.
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
