using UnityEngine;
using System.Collections;

public class GrowOnEnable : MonoBehaviour {

    public float growSpeed = 0.01f;
    
    
    private Vector3 _targetScale;
    private float _running = 0;

    void Awake()
    {
        _targetScale = transform.localScale;
    }

	
    void OnEnable()
    {
        this.transform.localScale = Vector3.zero;

        StartCoroutine(ScaleUp());
    }

    private IEnumerator ScaleUp()
    {
        _running = 0;

        while( _running < 1)
        {
            transform.localScale = Vector3.Lerp(Vector3.zero, _targetScale, _running);

            _running += growSpeed * Time.deltaTime;

            yield return 1;
        }
        
        transform.localScale = _targetScale;    
    }
}
