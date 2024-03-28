using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyBot : MonoBehaviour
{
    [SerializeField] private float _speed = 1.2f;
    [SerializeField] private Transform _target;

    private Vector3 _directionTarget;
    private Rigidbody _rigidbody;
    private float _distance = 5f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        _directionTarget = _target.position - transform.position;
        _directionTarget = _directionTarget.normalized;

        if (Vector3.Distance(transform.position, _target.position) > _distance)
        {
            Vector3 speed = new Vector3(_directionTarget.x * _speed,
            _rigidbody.velocity.y, _directionTarget.z);

            _rigidbody.velocity = speed;
            _rigidbody.velocity += Vector3.down;
        }
        else
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.velocity += Vector3.down;
        }
    }
}
