using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Aim _aim;
    private Vector3 _targetPosition;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _aim.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(Aim aim)
    {
        _aim = aim;
    }
}