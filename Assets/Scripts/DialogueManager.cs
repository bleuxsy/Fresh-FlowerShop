using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
  public TalkManager talkManager;
  public GameObject talkPanel;
  public Text talkText;
  public int talkIndex = 0;
  public bool isAction = true;
  public int characterId = 0;

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(0)) {
      talkPanel.SetActive(true);
      Action();
    }
  }

  public void Action() {
    talkText.text = Talk(characterId);
    
    talkPanel.SetActive(isAction);
  }

  string Talk(int id) {
    string talkData = talkManager.GetTalk(id, talkIndex);
    
    if(talkData == null) {
      isAction = false;
      talkIndex = 0;
      return "";
    }
    isAction = true;
    talkIndex++;
    return talkData;
  }
}
