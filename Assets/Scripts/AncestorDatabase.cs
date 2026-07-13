    using System.Collections.Generic;
    using UnityEngine;
    using System.Linq;

    public class AncestorDatabase : MonoBehaviour
    {
        public static AncestorDatabase Instance;

        [SerializeField]
        private List<AncestorData> ancestors = new();

        private void Awake()
        {
            Instance = this;
        }

        public AncestorData RollAncestor(Mythology mythology)
{
    List<AncestorData> validAncestors =
        ancestors.Where(a => a.mythology == mythology).ToList();

    Debug.Log($"Found {validAncestors.Count} {mythology} ancestors.");

    if (validAncestors.Count == 0)
    {
        Debug.LogError($"No {mythology} ancestors found!");
        return null;
    }

    return validAncestors[Random.Range(0, validAncestors.Count)];
}
    }
