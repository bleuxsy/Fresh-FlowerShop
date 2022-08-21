using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GotoOpening : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Opening");
    }
}
