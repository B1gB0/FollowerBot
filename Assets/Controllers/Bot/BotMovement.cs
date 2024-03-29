using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(DirectionTarget))]
public class BotMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private DirectionTarget _directionTarget;
    private float _distance = 5f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _directionTarget = GetComponent<DirectionTarget>();
    }

    public void MoveBotToDistance()
    {
        if (Vector3.Distance(transform.position, _directionTarget.Target.position) > _distance)
        {
            Move(_directionTarget.CalculateDirection());
        }
        else
        {
            Stop();
        }
    }

    private void Move(Vector3 directionTarget)
    {
        Vector3 speed = new Vector3(directionTarget.x * _speed,
        _rigidbody.velocity.y, directionTarget.z);

        _rigidbody.velocity = speed;
        _rigidbody.velocity += Vector3.down;
    }

    private void Stop()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.velocity += Vector3.down;
    }
}
