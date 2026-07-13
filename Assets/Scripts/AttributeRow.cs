using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttributeRowUI : MonoBehaviour
{
    public Button button;
    public Image arrow;
    public TMP_Text attributeName;

    public void SetSelected(bool selected)
    {
        arrow.rectTransform.localRotation =
            Quaternion.Euler(0, 0, selected ? 180 : 0);
    }
}