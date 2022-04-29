using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class FoodItemPopup : MonoBehaviour
{
    public float delay = 0.5f;
    void OnEnable()
    {
        transform.DOScale(Vector3.zero, 1.0f).From().SetEase(Ease.OutElastic).SetDelay(delay);
    }
}
