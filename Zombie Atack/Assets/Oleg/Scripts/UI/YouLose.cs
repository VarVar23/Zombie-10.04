using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public void Lose()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = true;
    }

    public void Resume()
    {
        Cursor.visible = false;
        SceneManager.LoadScene(0);
    }
}
