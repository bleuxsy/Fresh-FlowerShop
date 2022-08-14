using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
  public TalkManager talkManager;
  public GameObject talkPanel;
  public Text talkText;
  public GameObject openStore;
  public bool isAction = true;
  public int talkIndex = 0;

  public void OpenStore() {
    Action();
    openStore.SetActive(false);
  }

  public void TalkPanel() {
    Action();
  }

  public void Action() {
    // 인자 안에 GameObject scanObj
    // scanObject = scanObj;
    // ObjData objData = scanObject.GetComponent<ObjData>();
    talkText.text = Talk(1);
    // 인자 안에 objData.id
    
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
