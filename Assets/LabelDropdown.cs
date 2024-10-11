using TMPro;
using UnityEngine;

public class LabelDropdown : MonoBehaviour
{
    public TextMeshProUGUI label;
    public TMP_Dropdown dropdown;

    void Start()
    {
        label = GetComponentInChildren<TextMeshProUGUI>();
        dropdown = GetComponentInChildren<TMP_Dropdown>();
    }
}
