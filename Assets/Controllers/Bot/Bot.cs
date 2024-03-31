using UnityEngine;

[RequireComponent(typeof(BotMovement))]
public class Bot : MonoBehaviour
{
    private BotMovement _movement;

    private void Awake()
    {
        _movement = GetComponent<BotMovement>();
    }

    private void FixedUpdate()
    {
        _movement.MoveToDistance();
    }
}
