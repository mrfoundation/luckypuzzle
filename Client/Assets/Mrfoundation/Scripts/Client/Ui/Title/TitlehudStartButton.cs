using oojjrs.oui;
using UnityEngine;

namespace Assets.Mrfoundation.Scripts.Client.Ui.Title
{
    [RequireComponent(typeof(MyButton))]
    public class TitlehudStartButton : MonoBehaviour, MyButton.CallbackInterface
    {
        void MyButton.CallbackInterface.OnClick()
        {
        }
    }
}
