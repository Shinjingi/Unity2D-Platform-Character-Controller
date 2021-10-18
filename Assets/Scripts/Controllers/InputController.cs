using UnityEngine;

namespace Shinjingi
{
    public abstract class InputController : ScriptableObject
    {
        public abstract float RetrieveMoveInput();
        public abstract bool RetrieveJumpInput();
    }
}
