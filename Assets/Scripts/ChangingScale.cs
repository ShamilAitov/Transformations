using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangingScale : MonoBehaviour
{
    [SerializeField] private float _numberChanges;

    void Update()
    {
        transform.localScale += new Vector3(_numberChanges, _numberChanges, _numberChanges) * Time.deltaTime;
    }
}
