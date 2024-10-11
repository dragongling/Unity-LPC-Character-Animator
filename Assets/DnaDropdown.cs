using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Types;
using TMPro;
using UnityEngine;

public class DnaDropdown : MonoBehaviour
{
    public GameObject dropdownPrefab;
    public AtlasManager atlasManager;
    private readonly List<TMP_Dropdown.OptionData> emptyOptionList = new()
    {
        new(""),
    };
    private readonly Dictionary<string, GameObject> _dropdowns = new();
    
    private void Start()
    {
        foreach (var blockKey in DNABlockType.TypeList)
        {
            var obj = Instantiate(dropdownPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            obj.transform.SetParent(transform);
            obj.name = blockKey + "LabelDropdown";
            var label = obj.GetComponentInChildren<TextMeshProUGUI>();
            var dropdown = obj.GetComponentInChildren<TMP_Dropdown>();
            var key = blockKey.ToLower();
            label.text = key + ":";
            dropdown.options = emptyOptionList.Concat(atlasManager.ModelList.Where(item => item.StartsWith(key))
                .Select(item => new TMP_Dropdown.OptionData(item))).ToList();
            _dropdowns[blockKey] = obj;
        }
    }
}
