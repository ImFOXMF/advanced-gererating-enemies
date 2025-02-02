using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Aim _aim;
    
    public Enemy Enemy => _enemy;
    public Aim Aim => _aim;
}