using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
// �ʿ�Ӽ� : �Ѿ˰���, �ѱ�
public class PlayerFire : MonoBehaviour
{
    // �ʿ�Ӽ� : �Ѿ˰���, �ѱ�
    public GameObject bulletFactory;
    public Transform firePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
        // 1. ����ڰ� �߻��ư�� �������ϱ�.
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �Ѿ��� �־���Ѵ�.
            // -> �Ѿ� ���忡�� �Ѿ��� ������ �Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. �Ѿ��� �߻��ϰ� �ʹ�.(��ġ��Ų��.)
            bullet.transform.position = firePosition.position;
            // 4. �Ѿ��� �ѱ��� �������� ���ư����� �ϰ�ʹ�.
            bullet.transform.up = firePosition.up;
        }
    }
}
