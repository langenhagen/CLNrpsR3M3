using UnityEngine;
using System.Collections;

public class DeactivateOnEnable : MonoBehaviour {

    public GameObject target;

    void OnEnable()
    {
        target.SetActive(false);
    }
}
