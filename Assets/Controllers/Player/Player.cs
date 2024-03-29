using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerMovement _playerMovement;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        _playerMovement.PlayerCameraRotation.Rotate(_playerInput.CameraMovementX, _playerInput.CameraMovementY);
        _playerMovement.Move(_playerInput.MovementX, _playerInput.MovementY);
    }
}
