using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _lifetime;
    private Mover _mover;
    private Vector3 _spawnPoint;

    public WaitForSeconds WaitForLifeTime { get; private set; }

    private void Awake()
    {
        WaitForLifeTime = new WaitForSeconds(_lifetime);
        _mover = GetComponent<Mover>();
    }

    public void Move(Aim aim)
    {
        transform.position = _spawnPoint;
        _mover.Initialize(aim);
    }

    public void GetStartPoint(Vector3 spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }
}