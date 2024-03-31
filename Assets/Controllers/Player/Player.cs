using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerCameraRotation))]
public class Player : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerMovement _playerMovement;
    private PlayerCameraRotation _playerCameraRotation;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerCameraRotation = GetComponent<PlayerCameraRotation>();
    }

    private void Update()
    {
        _playerCameraRotation.Rotate(_playerInput.CameraMovementX, _playerInput.CameraMovementY);
        _playerMovement.Move(_playerInput.MovementX, _playerInput.MovementY);
    }
}
