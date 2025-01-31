using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Aim _aim;
    
    public Vector3 UnitVector { get; private set; }
    public Vector3 Start => transform.position;
    public Enemy Enemy => _enemy;
    public Aim Aim => _aim;

    private void Awake()
    {
        UnitVector = _direction.normalized;
    }
}