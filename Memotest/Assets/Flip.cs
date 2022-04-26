using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
   
 
    private void OnMouseUp()
    {
        transform.Rotate(0,0, 180);
       
        sendInfoToManager();

    }

    void sendInfoToManager() {
        //Debug.Log("SendInfo");
        GameManager.retrieveInfo(this.gameObject);
    }

   
}
