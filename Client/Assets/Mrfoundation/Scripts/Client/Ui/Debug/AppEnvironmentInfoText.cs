using Assets.Mrfoundation.Scripts.Client.Control.Primitive;
using UnityEngine;

namespace Assets.Mrfoundation.Scripts.Client.Ui.Debug
{
    [RequireComponent(typeof(MyTextForTmp))]
    public class AppEnvironmentInfoText : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<MyTextForTmp>().Text = MyEnv.AppEnvironmentInfo;
        }
    }
}
