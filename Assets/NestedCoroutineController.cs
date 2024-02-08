using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestedCoroutineController : MonoBehaviour
{
    public Fade cube0;
    public Fade cube1;
    public Fade cube2;

    bool _lock = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(NestedCoroutine());
        }
    }

    IEnumerator NestedCoroutine()
    {
        if(_lock) yield break;

        _lock = true;
        {
            yield return StartCoroutine(cube0.FadeOut());
            yield return StartCoroutine(cube1.FadeOut());
            yield return StartCoroutine(cube2.FadeOut());
        }
    }
}
