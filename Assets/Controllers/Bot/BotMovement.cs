using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BotMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _target;

    private float _distance = 5f;
    private Rigidbody _rigidbody;
    private Vector3 _directionTarget;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveToDistance()
    {
        if (Vector3.Distance(transform.position, _target.position) > _distance)
        {
            Move();
        }
        else
        {
            Stop();
        }
    }

    private Vector3 CalculateDirectionToTarget()
    {
        _directionTarget = _target.position - transform.position;
        _directionTarget = _directionTarget.normalized;

        return _directionTarget;
    }

    private void Move()
    {
        CalculateDirectionToTarget();

        Vector3 speed = new Vector3(_directionTarget.x * _speed,
        _rigidbody.velocity.y, _directionTarget.z);

        _rigidbody.velocity = speed;
        _rigidbody.velocity += Vector3.down;
    }

    private void Stop()
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.velocity += Vector3.down;
    }
}
