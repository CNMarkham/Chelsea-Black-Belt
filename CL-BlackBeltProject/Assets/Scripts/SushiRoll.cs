using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiRoll : MonoBehaviour, ISwipeable
{
    public IngredientController ingredientController;

    private bool alreadyCut;

    public void GetSwiped()
    {
        if (ingredientController.rice.activeSelf && ingredientController.noriPrefab.activeSelf && ingredientController.thinSalmonPrefab.activeSelf)
        {
            ingredientController.rice.SetActive(false);
            ingredientController.noriPrefab.SetActive(false);
            ingredientController.thinSalmonPrefab.SetActive(false);
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
