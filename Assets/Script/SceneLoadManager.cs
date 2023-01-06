using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Base;

public class SceneLoadManager : Singleton<SceneLoadManager>
{
   

    public void LoadSceneByName(string name)
    {
        Debug.Log("s");
       
        SceneManager.LoadScene(name);
    }


    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

}
