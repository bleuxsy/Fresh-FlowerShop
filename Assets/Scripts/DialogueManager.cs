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
    public int talkIndex;
    public int characterId;
    public bool isAction = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            talkPanel.SetActive(true);
            Action();
        }
    }

    public void Action()
    {
        talkText.text = Talk(characterId);
        talkPanel.SetActive(isAction);
    }

    public string Talk(int characterId)
    {
        string talkData = talkManager.GetTalk(characterId, talkIndex);

        if (talkData == null)
        {
            isAction = false;
            talkIndex = 0;
            if (characterId % 100==0)
                SceneManager.LoadScene("MG-Memo");
            else
            {
                SceneManager.LoadScene("Main");
                characterId += 100;
            }
            //220822 이서현 편집, 추후 다시 코딩해야 하는 부분...
            return "";
        }
        isAction = true;
        talkIndex++;
        return talkData;
    }
}
