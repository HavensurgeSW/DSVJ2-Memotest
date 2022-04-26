using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int flippedCards;
    public static GameObject card1;
    public static GameObject card2;
    void Start()
    {
        flippedCards = 0;
        card1 = null;
        card2 = null;
    }

    public static void retrieveInfo(GameObject card)
    {

        if (card2 == null&&flippedCards==1&&card!=card2)
        {
           
            card2 = card;
            flippedCards++;

            Debug.Log(card2.tag);
            
        }
        if (card1 == null&&flippedCards==0)
        {
            card1 = card;
            flippedCards++;
            Debug.Log(card1.tag);
        }

    }

    void Update()
    {
        if (flippedCards == 2) {
            flippedCards = 0;
            if (card1.gameObject.CompareTag(card2.gameObject.tag))
            {
                card1.SetActive(false);
                card2.SetActive(false);
                Debug.Log("Compare Succesful");
            }
            else {
                card1.transform.Rotate(0, 0, 180);
                card2.transform.Rotate(0, 0, 180);
                Debug.Log("Compare fail");
            }
            card1 = null;
            card2 = null;
        }

    }


}
