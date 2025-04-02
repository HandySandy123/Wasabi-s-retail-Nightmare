using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    
    [SerializeField]
    private float MoveSpeed = 15f;
    
    [SerializeField]
    public InputActionReference MoveAction, InteractAction;
    
    private Rigidbody2D rb2d;
    private Animator animator;
    private Vector2 _movementDirection;
    private SpriteRenderer spriteRenderer;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        InteractAction.action.started += Interact;
    }

    // Update is called once per frame
    void Update()
    {
        _movementDirection = MoveAction.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(_movementDirection.x * MoveSpeed, _movementDirection.y * MoveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Furniture") && other.gameObject.TryGetComponent<SpriteRenderer>(out SpriteRenderer furnitureSpriteRenderer))
        {
            int furnitureLayer = furnitureSpriteRenderer.sortingLayerID;
            SortSprites(furnitureLayer, furnitureSpriteRenderer);
        }
    }

    private void SortSprites(int sortingLayer, SpriteRenderer furnitureSpriteRenderer)
    {
        Debug.Log(sortingLayer);
        //spriteRenderer.sortingLayerID = sortingLayer;
    }

    void OnDisable()
    {
        InteractAction.action.started -= Interact;
    }

    void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Interact");
    }
}
