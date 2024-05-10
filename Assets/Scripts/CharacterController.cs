using UnityEngine.InputSystem;
using UnityEngine;
using Unity.VisualScripting;

public class CharacterController : Controller
{
    private Camera camera;
    private Vector3 cameraPos;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        cameraPos = new Vector3(transform.position.x, transform.position.y, -10);
        camera.transform.position = cameraPos;
    }

    // 키에 따른 이동 방향
    public void OnMove(InputValue value)
    {
        Vector2 moveDirection = value.Get<Vector2>().normalized;
        CallbackMove(moveDirection);
    }

    // 마우스 위치에 따른 캐릭터 좌우 반전
    public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePos);
        mousePos = (worldPos - (Vector2)transform.position).normalized;
        CallbackLook(mousePos);
    }
}
