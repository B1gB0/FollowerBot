using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private float _horizontalTurnSensitivity;
    [SerializeField] private float _verticalTurnSensitivity = 10f;
    [SerializeField] private float _verticalMinAngle = -89f;
    [SerializeField] private float _verticalMaxAngle = 89f;

    private Transform _transform;
    private float _cameraAngle = 0f;

    public Transform CameraTransform => _cameraTransform;

    private void Awake()
    {
        _cameraAngle = _cameraTransform.localEulerAngles.x;
        _transform = transform;
    }

    public void Rotate(float directionX, float directionY)
    {
        _cameraAngle -= directionY * _verticalTurnSensitivity;
        _cameraAngle = Mathf.Clamp(_cameraAngle, _verticalMinAngle, _verticalMaxAngle);
        _cameraTransform.localEulerAngles = Vector3.right * _cameraAngle;

        _transform.Rotate(Vector3.up * _horizontalTurnSensitivity * directionX);
    }
}
