using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMawar : MonoBehaviour
{
    public static InfoMawar instance;
    public GameObject TombolInfo;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        TombolInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
