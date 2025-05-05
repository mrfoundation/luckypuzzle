using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Assets.Mrfoundation.Scripts.Client.Control.Primitive
{
    [RequireComponent(typeof(TMPro.TextMeshProUGUI))]
    [RequireComponent(typeof(LocalizeStringEvent))]
    public class MyTextForTmp : MonoBehaviour
    {
        public string Text { get => GetComponent<TextMeshProUGUI>().text; set => GetComponent<TextMeshProUGUI>().text = value; }
    }
}
