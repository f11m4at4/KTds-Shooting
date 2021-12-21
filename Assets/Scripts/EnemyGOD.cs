using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// �����ð��� �ѹ��� ���� �����ϰ� �ʹ�.
// �ʿ�Ӽ� : ������, �����ð�, ����ð�
public class EnemyGOD : MonoBehaviour
{
    // �ʿ�Ӽ� : ������, �����ð�, ����ð�
    public GameObject enemyFactory;
    public float createTime = 2;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ð��� �ѹ��� ���� �����ϰ� �ʹ�.
        // 1. �ð��� �귶���ϱ�
        currentTime += Time.deltaTime;
        // 2. �����ð��� �����ϱ�
        if (currentTime > createTime)
        {
            // ����ð� �ʱ�ȭ
            currentTime = 0;
            // 3. ���� �־�� �Ѵ�. (����)
            GameObject enemy = Instantiate(enemyFactory);
            // 4. ���� ��ġ�ϰ� �ʹ�.
            enemy.transform.position = transform.position;
        }
    }
}
