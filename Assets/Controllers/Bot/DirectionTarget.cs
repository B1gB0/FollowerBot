using UnityEngine;

public class DirectionTarget : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _directionTarget;

    public Transform Target => _target;

    public Vector3 CalculateDirection()
    {
        _directionTarget = _target.position - transform.position;
        _directionTarget = _directionTarget.normalized;

        return _directionTarget;
    }
}
