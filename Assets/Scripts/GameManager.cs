using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  public GameObject openStore;

  public void NextSceneWithString() {
    SceneManager.LoadScene("Episode");
  }

  public void OpenStore() {
    NextSceneWithString();
  }
}
