using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
   
    private bool isFlipped = false;
    private void OnMouseUp()
    {
        transform.Rotate(0,0, 180);
        isFlipped = !isFlipped;
        sendInfoToManager();

    }

    void sendInfoToManager() {
        //Debug.Log("SendInfo");
        GameManager.retrieveInfo(this.gameObject);
    }

    void flip() {
        OnMouseUp();
    }
}
