using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ��ư�� Ŭ������ �� ���� ��ȯ�ǵ��� �ϰ�ʹ�.
public class GameStart : MonoBehaviour
{
    public void GotoGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
