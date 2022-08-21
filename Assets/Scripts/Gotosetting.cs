using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gotosetting : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("setting");
    }
}
