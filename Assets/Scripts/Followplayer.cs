using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    Camera mainCamera;
    public Transform player;
    RectTransform trans;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        trans = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpositon = mainCamera.WorldToScreenPoint(player.position);

        trans.position = playerpositon;

    }
}
