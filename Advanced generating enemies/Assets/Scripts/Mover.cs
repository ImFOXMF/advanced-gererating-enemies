using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Aim _aim;

    private Vector3 _targetPosition;
    private bool _isMoving = false;

    private void Update()
    {
        if (_isMoving)
            transform.position = Vector3.MoveTowards(transform.position, _aim.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(Aim aim)
    {
        _aim = aim;
        _isMoving = true;
    }
}