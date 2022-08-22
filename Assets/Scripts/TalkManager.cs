using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    void Start()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(100, new string[] { "안녕하세요!", "꽃다발 주문하려고 하는데요.", "튤립이랑 장미는 꼭 들어갔으면 좋겠고, 안개꽃도 있으면 좋겠어요. 종이는 노란색이랑 하얀색, 리본은 파란색으로 해주세요!" });
        talkData.Add(110, new string[] { "와, 딱 제가 생각했던 꽃다발이에요!" });
        talkData.Add(120, new string[] { "제가 생각했던 것과는 조금 다른 것 같아요..." });

        talkData.Add(200, new string[] { "안녕하세요.", "화분을 사려고 하는데요.", "허브 화분을 찾고 있어요. 향기가 나는 식물이요!" });
        talkData.Add(210, new string[] { "와 정말 좋은 향기가 나요! 감사합니다!" });
        talkData.Add(220, new string[] { "감사합니다..." });

        talkData.Add(300, new string[] { "안녕하세요!", "카네이션하고 안개꽃 그리고 유칼립투스도 넣어주세요. 자주색 종이에 보라색 리본으로 부탁드립니다." });
        talkData.Add(310, new string[] { "감사합니다. 좋은 하루 보내세요." });
        talkData.Add(320, new string[] { "제가 주문한 것과는 조금 다르네요." });

        talkData.Add(400, new string[] { "안녕하세요.", "아글라오네마 있을까요?" });
        talkData.Add(410, new string[] { "감사합니다!" });
        talkData.Add(420, new string[] { "제가 주문한 게 맞나요? 감사합니다." });

    }

    public string GetTalk(int characterId, int talkIndex)
    {
        if (talkIndex == talkData[characterId].Length)
            return null;
        return talkData[characterId][talkIndex];
    }
}
