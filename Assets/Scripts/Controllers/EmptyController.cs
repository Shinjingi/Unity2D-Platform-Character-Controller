using UnityEngine;

namespace Shinjingi
{
    [CreateAssetMenu(fileName = "EmptyController", menuName = "InputController/EmptyController")]
    public class EmptyController : InputController
    {
        public override bool RetrieveJumpHoldInput()
        {
            return false;
        }

        public override bool RetrieveJumpInput()
        {
            return false;
        }

        public override float RetrieveMoveInput()
        {
            return 0;
        }
    }
}
