using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
