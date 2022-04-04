using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bookopener : MonoBehaviour
{
    
    
    public void ShowRecipe(GameObject recipe)
    {
        recipe.transform.DOScale(Vector3.zero, 1.0f).From().SetEase(Ease.OutElastic);
    }

}
