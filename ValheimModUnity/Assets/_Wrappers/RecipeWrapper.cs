using UnityEngine;

namespace Veilheim.UnityWrappers
{
    /// <summary>
    /// A wrapper for Valheim's <see cref="Recipe" />.
    /// </summary>
    [UnityEngine.CreateAssetMenu]
    public class RecipeWrapper : Recipe
    {
        public bool includeInRelease = false;
    }
}