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

    // 필요속성 : 카운트
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
            // 3 마리 잡을 때마다 *2 씩 속도 커지기
            if (killCount % 3 == 0)
            {
                scrollSpeed *= 2;
                // 단, 1 을 넘어 갈 수 없도록 처리
                scrollSpeed = Mathf.Clamp(scrollSpeed, 0, 1);
            }
        }
    }

    public void Kill()
    {
        killCount++;
        // 3 마리 잡을 때마다 *2 씩 속도 커지기
        if(killCount % 3 == 0)
        {
            scrollSpeed *= 2;
            // 단, 1 을 넘어 갈 수 없도록 처리
            scrollSpeed = Mathf.Clamp(scrollSpeed, 0, 1);
        }

    }

    // 싱글톤 객체를 만들어서 사용하고 싶다.
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
        // 배경이 계속 스크롤되도록 하고 싶다.
        // P = P0 + vt
        mat.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
