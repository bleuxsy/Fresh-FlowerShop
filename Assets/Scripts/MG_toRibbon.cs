using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MG_toRibbon : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("MG-Ribbon");
    }
}
