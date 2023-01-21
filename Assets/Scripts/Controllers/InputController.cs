using UnityEngine;

namespace Shinjingi
{
    public abstract class InputController : ScriptableObject
    {
        public abstract float RetrieveMoveInput(GameObject gameObject);
        public abstract bool RetrieveJumpInput(GameObject gameObject);
        public abstract bool RetrieveJumpHoldInput(GameObject gameObject);
    }
}
