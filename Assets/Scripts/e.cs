using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit(); // 실행 파일에서는 게임 종료
        Debug.Log("게임 종료!"); // 에디터에서 테스트용 로그
    }
}
