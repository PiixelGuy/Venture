using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ingredient
{
    public MaterialData material;
    public int amount;
}

[CreateAssetMenu(menuName = "Venture/Recipe")]
public class RecipeData : ScriptableObject
{
    public string recipeName;

    public List<Ingredient> ingredients;

    public MaterialData output;

    public int outputAmount;
}