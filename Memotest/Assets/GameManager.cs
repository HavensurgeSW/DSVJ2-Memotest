using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int flippedCards;
    public static bool flipEnabler;
    public static GameObject card1;
    public static GameObject card2;
    void Start()
    {
        flippedCards = 0;
        card1 = null;
        card2 = null;
        flipEnabler = true;

    }

    public static void RetrieveInfo(GameObject card)
    {

        if (card2 == null &&
            flippedCards==1 &&
            card!=card1 &&
            flipEnabler)
        {
           
            card2 = card;
            flippedCards++;
            Debug.Log(card2.tag);
        }

        if (card1 == null &&
            flippedCards==0 &&
            flipEnabler)
        {
            card1 = card;
            flippedCards++;
            Debug.Log(card1.tag);
        }

    }

    void Update()
    {
        if (flippedCards == 2) {
             flipEnabler = false;
            if (card1.gameObject.CompareTag(card2.gameObject.tag))
            {
                flippedCards = 0;
                card1.SetActive(false);
                card2.SetActive(false);
                Debug.Log("Compare Succesful");
                card1 = null;
                card2 = null;
                flipEnabler = true;

            }
            else {
                flippedCards = 0;
                flipEnabler = false;
                Invoke("turnTimer",1.5f);

            }
           
        }

    }

    private void turnTimer() {
        
        card1.transform.Rotate(0, 0, 180);
        card2.transform.Rotate(0, 0, 180);
        Debug.Log("Compare fail");
        card1 = null;
        card2 = null;
        flipEnabler = true;

    }


}
