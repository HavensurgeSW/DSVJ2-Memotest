using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Funciona pls");
        transform.Rotate(0,0, 180);
    }
}
