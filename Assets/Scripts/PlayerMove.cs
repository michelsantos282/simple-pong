using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed = 100f;
    private Vector2 directionInput = Vector2.zero;

    private void Update()
    {
        Vector3 newPos = transform.position;

        newPos.y += directionInput.y * speed * Time.deltaTime;
        newPos.y = Mathf.Clamp(newPos.y, -4, 4);

    
        transform.position = newPos;
    }

    public void OnMove(InputValue value)
    {
        directionInput = value.Get<Vector2>();
    }
}
