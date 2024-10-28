using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : MonoBehaviour
{
    Camera mainCamera;

    [Header("���콺 ������� ���� (���� ���� ������ �����)")]
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

        mousePosition.z = 0;

        transform.position = Vector3.Lerp(transform.position, mousePosition, mouseSensitivity);
    }
}
