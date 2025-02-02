using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _startWaypoint = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _waypoints[_startWaypoint].position)
        {
            _startWaypoint++;
        }
        else if (_startWaypoint == _waypoints.Length - 1)
        {
            _startWaypoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_startWaypoint].transform.position,
            _speed * Time.deltaTime);
    }
}