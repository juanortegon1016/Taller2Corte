using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject prefabARotar;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            prefabARotar.transform.Rotate(Vector3.up * Time.deltaTime * 50f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            prefabARotar.transform.Rotate(Vector3.down * Time.deltaTime * 50f);
        }
    }