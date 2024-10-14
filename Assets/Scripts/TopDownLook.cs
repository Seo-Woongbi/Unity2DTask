using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownLook : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) >= 90f;
    }
}
