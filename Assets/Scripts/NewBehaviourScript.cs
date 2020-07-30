using System;
using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    IEnumerator MyCoroutine()
    {
        object damage;
        Debug.Log(("Hello World"));
        yield return new WaitForSeconds(2);
        
        Debug.Log(("Hello World lan 2"));
        //Debug.Log(("damage: "+ damage));
        yield return new WaitForSeconds(2);
        
        Debug.Log(("Hello World lan 3(4s)"));
    }

//    private void Start()
//    {
//        StartCoroutine(MyCoroutine(10));
//    }
    
}
