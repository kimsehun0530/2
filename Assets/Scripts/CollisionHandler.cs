using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "S":
                Debug.Log("시작합니다");
                break;

             case "Finish":
                LoadNextLevel();
                break;
                
            default:
                ReloadLevel();
                break;
        }
    }

    void LoadNextLevel()
    {
      int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
      int nextSceneIndex = currenSceneIndex + 1;
      if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
      {
        nextSceneIndex = 0;
      }

      SceneManager.LoadScene(nextSceneIndex);
    }
 
    void ReloadLevel()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currenSceneIndex);
    }
}
