using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] BoardStatus boardStatus = null;
    [SerializeField] GameObject[] CardUIObjs = new GameObject[4];
    [SerializeField] GameObject[] CardObjs = new GameObject[4];
    private Transform[] BoardTransforms = new Transform[22];

    [SerializeField] PlayerManager[] playerManagers = new PlayerManager[2];

    [SerializeField] BoardManager BoardManager;


    public void Movement(int playerID,int boardID)
    {
        playerManagers[playerID].transform.position = BoardTransforms[boardID].position;
    }

    public void DaiceRoll(int playerBoard,int i)
    {
        var daiceNum = Random.Range(1, 3);
        playerBoard += daiceNum;
    }

    public void Draw(int i)
    {
        if (i > 8)
            return;

        var random = Random.Range(0, 4);

        var playerManager = this.playerManagers[0];
        var card= Instantiate(CardUIObjs[random]);
        card.transform.SetParent(playerManager.transform);
        playerManager.Hands.Add(card);

    }

    public void Summon(int playerID,int handID)
    {
        var playerManager = this.playerManagers[playerID];
        var cardID = playerManager.HandIDs[handID];
        var summonPos = BoardTransforms[playerManager.BoardNum].position;
        Instantiate(CardObjs[cardID], summonPos, Quaternion.identity);

        playerManager.Hands.RemoveAt(handID);
        playerManager.HandIDs.RemoveAt(handID);
        Destroy(playerManager.Hands[handID]);
    }
}
