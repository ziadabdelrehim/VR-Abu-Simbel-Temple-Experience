using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PyramidsSceneLoader : MonoBehaviour
{
    public void LoadPyramidScene()
    {
        

        SceneManager.LoadScene(2);

    }

    public void LoadAbuSimbleScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }
}
