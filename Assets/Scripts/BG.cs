using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� ��� ��ũ�ѵǵ��� �ϰ� �ʹ�.
// �ʿ�Ӽ� : ��ũ�Ѽӵ�, Material(����)
public class BG : MonoBehaviour
{
    // �ʿ�Ӽ� : ��ũ�Ѽӵ�, Material(����)
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
        // ����� ��� ��ũ�ѵǵ��� �ϰ� �ʹ�.
        // P = P0 + vt
        mat.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
