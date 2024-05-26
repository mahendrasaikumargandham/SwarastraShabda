using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EnterLevel2() {
        SceneManager.LoadScene("Level2");
    }

    public void EnterLevel3() {
        SceneManager.LoadScene("Level3");
    }
}
