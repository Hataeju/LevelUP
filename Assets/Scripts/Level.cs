using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Level : MonoBehaviour
{
    private static Level instance = null;
    public static Level Instance { get { return instance; } }
    public TextMeshProUGUI tmpNumber;
    public int tmp = 1;

    private void Awake()
    {
        if (instance == null) instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpNumber.text = tmp.ToString();
    }
}
