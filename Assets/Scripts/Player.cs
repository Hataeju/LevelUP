using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : MonoBehaviour
{
    const float Create_Position_Y = -3f;

    Camera mainCamera;

    [Header("마우스 따라오는 감도 (높은 수록 빠르게 따라옴)")]
    [Range(0, 1)]
    [SerializeField] float mouseSensitivity = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

// Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        float borderLeft = -4.25f + transform.localScale.x / 2;
        float borderRight = 4.25f - transform.localScale.x / 2;

        mousePosition.y = Create_Position_Y;
        mousePosition.z = -3;
        if (mousePosition.x < borderLeft)
        {
            mousePosition.x = borderLeft;
        }
        else if (mousePosition.x > borderRight)
        {
            mousePosition.x = borderRight;
        }
        transform.position = Vector3.Lerp(transform.position, mousePosition, mouseSensitivity);
    }
}
