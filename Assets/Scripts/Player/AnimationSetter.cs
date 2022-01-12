using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSetter : MonoBehaviour
{
    private Animator _animator;

    public static class Stats
    {
        public const string IsMove = "IsMove";
        public const string Hit = "Hit";
    }

    private void Start()
    {
        TryGetComponent<Animator>(out _animator);
    }

    public void StartMove()
    {
        Debug.Log("Start Move");
        _animator.SetBool(Stats.IsMove, true);
    }

    public void StopMove()
    {
        _animator.SetBool(Stats.IsMove, false);
    }

    public void TakeDamage()
    {
        _animator.SetTrigger(Stats.Hit);
    }
}
