using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace CSD
{



public class UIAppear : MonoBehaviour
{
    //[SerializeField] private Image customImage;
    [SerializeField] public Text customText;



    /* void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.CompareTag("Player"))
         {
                 customImage.enabled = true;
                 customText.enabled = true;
         }
     }

     void OnTriggerExit2D(Collider2D collision)
     {
         if (collision.CompareTag("Player"))
         {
                 customImage.enabled = false;
                 customText.enabled = false;
         }
     }*/


    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.X))
            {
                //customImage.enabled = true;
                customText.enabled = true;
            }

            else
            {
                //customImage.enabled = false;
                customText.enabled = false;
            }
        }
    }
}
}