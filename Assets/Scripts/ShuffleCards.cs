using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleCards : MonoBehaviour
{

    //spade cards
    public GameObject CardSpadeA;
    public GameObject CardSpade2;
    // public GameObject CardSpade3;
    // public GameObject CardSpade4;
    // public GameObject CardSpade5;
    // public GameObject CardSpade6;
    // public GameObject CardSpade7;
    // public GameObject CardSpade8;
    // public GameObject CardSpade9;
    // public GameObject CardSpade10;
    // public GameObject CardSpadeJ;
    // public GameObject CardSpadeQ;
    // public GameObject CardSpadeK;

    // //clove cards
    // public GameObject CardCloveA;
    // public GameObject CardClove2;
    // public GameObject CardClove3;
    // public GameObject CardClove4;
    // public GameObject CardClove5;
    // public GameObject CardClove6;
    // public GameObject CardClove7;
    // public GameObject CardClove8;
    // public GameObject CardClove9;
    // public GameObject CardClove10;
    // public GameObject CardCloveJ;
    // public GameObject CardCloveQ;
    // public GameObject CardCloveK;

    // //diamond cards
    // public GameObject CardDiamondA;
    // public GameObject CardDiamond2;
    // public GameObject CardDiamond3;
    // public GameObject CardDiamond4;
    // public GameObject CardDiamond5;
    // public GameObject CardDiamond6;
    // public GameObject CardDiamond7;
    // public GameObject CardDiamond8;
    // public GameObject CardDiamond9;
    // public GameObject CardDiamond10;
    // public GameObject CardDiamondJ;
    // public GameObject CardDiamondQ;
    // public GameObject CardDiamondK;

    // //heart cards
    // public GameObject CardHeartA;
    // public GameObject CardHeart2;
    // public GameObject CardHeart3;
    // public GameObject CardHeart4;
    // public GameObject CardHeart5;
    // public GameObject CardHeart6;
    // public GameObject CardHeart7;
    // public GameObject CardHeart8;
    // public GameObject CardHeart9;
    // public GameObject CardHeart10;
    // public GameObject CardHeartJ;
    // public GameObject CardHeartQ;
    // public GameObject CardHeartK;


    //player1
    public GameObject PlayerArea;
    public GameObject CardArea;

    // //player2
    // public GameObject PlayerArea2;
    // public GameObject CardArea2;

    // //player3
    // public GameObject PlayerArea3;
    // public GameObject CardArea3;

    // //player4
    // public GameObject PlayerArea4;
    // public GameObject CardArea4;

    // //Host
    // public GameObject HostArea;
    // public GameObject CardArea5;

    public GameObject Background;

    List<GameObject> deck =  new List<GameObject>();
    



    // Start is called before the first frame update
    void Start()
    {
        deck.Add(CardSpadeA);
        deck.Add(CardSpade2);
        // deck.Add(CardSpade3);
        // deck.Add(CardSpade4);
        // deck.Add(CardSpade5);
        // deck.Add(CardSpade6);
        // deck.Add(CardSpade7);
        // deck.Add(CardSpade8);
        // deck.Add(CardSpade9);
        // deck.Add(CardSpade10);
        // deck.Add(CardSpadeJ);
        // deck.Add(CardSpadeQ);
        // deck.Add(CardSpadeK);

        // deck.Add(CardCloveA);
        // deck.Add(CardClove2);
        // deck.Add(CardClove3);
        // deck.Add(CardClove4);
        // deck.Add(CardClove5);
        // deck.Add(CardClove6);
        // deck.Add(CardClove7);
        // deck.Add(CardClove8);
        // deck.Add(CardClove9);
        // deck.Add(CardClove10);
        // deck.Add(CardCloveJ);
        // deck.Add(CardCloveQ);
        // deck.Add(CardCloveK);

        // deck.Add(CardHeartA);
        // deck.Add(CardHeart2);
        // deck.Add(CardHeart3);
        // deck.Add(CardHeart4);
        // deck.Add(CardHeart5);
        // deck.Add(CardHeart6);
        // deck.Add(CardHeart7);
        // deck.Add(CardHeart8);
        // deck.Add(CardHeart9);
        // deck.Add(CardHeart10);
        // deck.Add(CardHeartJ);
        // deck.Add(CardHeartQ);
        // deck.Add(CardHeartK);

        // deck.Add(CardDiamondA);
        // deck.Add(CardDiamond2);
        // deck.Add(CardDiamond3);
        // deck.Add(CardDiamond4);
        // deck.Add(CardDiamond5);
        // deck.Add(CardDiamond6);
        // deck.Add(CardDiamond7);
        // deck.Add(CardDiamond8);
        // deck.Add(CardDiamond9);
        // deck.Add(CardDiamond10);
        // deck.Add(CardDiamondJ);
        // deck.Add(CardDiamondQ);
        // deck.Add(CardDiamondK);

    }

    public void OnClick(){
        for (int i = 0; i < 2; i++)
        {
            GameObject playerCard = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0,0,0), Quaternion.identity);
            playerCard.transform.SetParent(CardArea.transform, false);

            // GameObject playerCard2 = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0,0,0), Quaternion.identity);
            // playerCard2.transform.SetParent(CardArea2.transform, false);
            
            // GameObject playerCard3 = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0,0,0), Quaternion.identity);
            // playerCard3.transform.SetParent(CardArea3.transform, false);

            // GameObject playerCard4 = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0,0,0), Quaternion.identity);
            // playerCard4.transform.SetParent(CardArea4.transform, false);

            // GameObject playerCard5 = Instantiate(deck[Random.Range(0, deck.Count)], new Vector3(0,0,0), Quaternion.identity);
            // playerCard5.transform.SetParent(CardArea5.transform, false);
        }
     
    }

}
