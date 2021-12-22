using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경이 계속 스크롤되도록 하고 싶다.
// 필요속성 : 스크롤속도, Material(재질)
public class BG : MonoBehaviour
{
    // 필요속성 : 스크롤속도, Material(재질)
    public float scrollSpeed = 0.2f;
    // GameObject -> MeshRenderer -> Material
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        // 배경이 계속 스크롤되도록 하고 싶다.
        // P = P0 + vt
        mat.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
