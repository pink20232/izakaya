using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MuffinClicker : MonoBehaviour
{
    [SerializeField]
    TMP_Text totalMuffinText;
    int totalMuffins;

        public void OnMuffinClicked ()
        {
            Debug.Log("Muffin Clicked");
            totalMuffins++;
            totalMuffinText.text = totalMuffins.ToString() + " Muffins";
        
        }
    }

 