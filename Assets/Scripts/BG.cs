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

    // �ʿ�Ӽ� : ī��Ʈ
    int killCount = 0;

    public int KC
    {
        get
        {
            return killCount;
        }
        set
        {
            killCount = value;
            // 3 ���� ���� ������ *2 �� �ӵ� Ŀ����
            if (killCount % 3 == 0)
            {
                scrollSpeed *= 2;
                // ��, 1 �� �Ѿ� �� �� ������ ó��
                scrollSpeed = Mathf.Clamp(scrollSpeed, 0, 1);
            }
        }
    }

    public void Kill()
    {
        killCount++;
        // 3 ���� ���� ������ *2 �� �ӵ� Ŀ����
        if(killCount % 3 == 0)
        {
            scrollSpeed *= 2;
            // ��, 1 �� �Ѿ� �� �� ������ ó��
            scrollSpeed = Mathf.Clamp(scrollSpeed, 0, 1);
        }

    }

    // �̱��� ��ü�� ���� ����ϰ� �ʹ�.
    public static BG Instance = null;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

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
