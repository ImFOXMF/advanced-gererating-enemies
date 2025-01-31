using System;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _lifetime;
    private Mover _mover;
    private Vector3 _spawnPont;
    
    public WaitForSeconds WaitForLifeTime{ get; private set; }

    private void Awake()
    {
        WaitForLifeTime = new WaitForSeconds(_lifetime);
        _mover = GetComponent<Mover>();
    }

    public void Move(Aim aim)
    {
        transform.position = _spawnPont;
        _mover.Initialize(aim);
    }

    public void GetStartPoint(Vector3 startPoint)
    {
        _spawnPont = startPoint;
    }
}