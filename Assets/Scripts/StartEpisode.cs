using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEpisode : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Episode");
    }
}
