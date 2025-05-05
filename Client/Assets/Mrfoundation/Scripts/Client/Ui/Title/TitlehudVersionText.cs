using Assets.Mrfoundation.Scripts.Client.Control.Primitive;
using UnityEngine;

namespace Assets.Mrfoundation.Scripts.Client.Ui.Title
{
    [RequireComponent(typeof(MyTextForTmp))]
    public class TitlehudVersionText : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<MyTextForTmp>().Text = Application.companyName + " " + Application.productName + " " + Application.version;
        }
    }
}
