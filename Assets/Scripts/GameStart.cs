using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 버튼을 클릭했을 때 씬이 전환되도록 하고싶다.
public class GameStart : MonoBehaviour
{
    public void GotoGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
