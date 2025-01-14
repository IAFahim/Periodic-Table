using System;
using _Root.Scripts.Elements.Runtime;
using Pancake.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class UIShowElements : MonoBehaviour
    {
        [SerializeField] private Image elementBG;
        [SerializeField] private TMP_Text nameTMP;
        [SerializeField] private TMP_Text electronCountTMP;
        [SerializeField] private int currentElement = 1;
        [SerializeField] private SelectedElementsScriptableObject selectedElementsScriptable;

        [SerializeField] private string elementNameKey = "element";

        private void Start()
        {
            currentElement = Data.Load(elementNameKey, 1);
            SetElement(selectedElementsScriptable, currentElement);
        }

        private void SetElement(SelectedElementsScriptableObject selectedElementsScriptable, int index)
        {
            ElementScriptableObject elementScriptableObject = selectedElementsScriptable.scriptableElements[index];
            nameTMP.text = elementScriptableObject.elementShortName;
            electronCountTMP.text = elementScriptableObject.electrons.ToString();
            this.selectedElementsScriptable.selectedElement = elementScriptableObject;
        }
    }
}