using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
   
 
    private void OnMouseUp()
    {
        FlipCard();
        SendInfoToManager();
    }

    private void SendInfoToManager() {
        //Debug.Log("SendInfo");
        GameManager.RetrieveInfo(gameObject);
    }

    private void FlipCard() {
        if (GameManager.flipEnabler)
            transform.Rotate(0, 0, 180);
    }

   
}
