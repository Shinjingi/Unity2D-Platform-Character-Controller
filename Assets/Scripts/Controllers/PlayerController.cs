using UnityEngine;

namespace Shinjingi
{
    [CreateAssetMenu(fileName = "PlayerController", menuName = "InputController/PlayerController")]
    public class PlayerController : InputController
    {
        private PlayerInputActions _inputActions;
        private bool _isJumping;

        private void OnEnable()
        {
            _inputActions = new PlayerInputActions();
            _inputActions.Gameplay.Enable();
            _inputActions.Gameplay.Jump.started += JumpStarted;
            _inputActions.Gameplay.Jump.canceled += JumpCanceled;
        }

        private void OnDisable()
        {
            _inputActions.Gameplay.Disable();
            _inputActions.Gameplay.Jump.started -= JumpStarted;
            _inputActions.Gameplay.Jump.canceled -= JumpCanceled;
            _inputActions = null;
        }

        private void JumpCanceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _isJumping = false;
        }

        private void JumpStarted(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _isJumping = true;
        }

        public override bool RetrieveJumpInput(GameObject gameObject)
        {
            return _isJumping;
        }

        public override float RetrieveMoveInput(GameObject gameObject)
        {
            return _inputActions.Gameplay.Move.ReadValue<Vector2>().x;
        }
    }
}
