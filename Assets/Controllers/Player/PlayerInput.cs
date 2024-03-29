using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private const string CameraDirectionX = "Mouse X";
    private const string CameraDirectionY = "Mouse Y";
    private const string MovementDirectionX = "Horizontal";
    private const string MovementDirectionY = "Vertical";

    public float MovementX { get; private set; }

    public float MovementY { get; private set; }

    public float CameraMovementX { get; private set; }

    public float CameraMovementY { get; private set; }


    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        MovementX = Input.GetAxis(MovementDirectionX);
        MovementY = Input.GetAxis(MovementDirectionY);
        CameraMovementX = Input.GetAxis(CameraDirectionX);
        CameraMovementY = Input.GetAxis(CameraDirectionY);
    }
}
