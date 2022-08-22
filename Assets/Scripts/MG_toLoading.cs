using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MG_toLoading : MonoBehaviour
{
    public int talkIndex;
    public void SceneChange()
    {
        talkIndex = 10;
        SceneManager.LoadScene("MG-Loading");
    }
}