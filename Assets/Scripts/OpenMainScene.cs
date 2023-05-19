using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMainScene : MonoBehaviour
{
    public void OpenScene()
    {
        SceneManager.LoadScene(1);
    }

}
