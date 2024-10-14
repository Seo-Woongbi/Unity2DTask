using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsRun = Animator.StringToHash("IsRun");

    private readonly float magnituteThreshold = 0.5f;

    private void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsRun, obj.magnitude > magnituteThreshold);
    }
}