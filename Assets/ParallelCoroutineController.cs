using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallelCoroutineController : MonoBehaviour
{
    public Fade cube0;
    public Fade cube1;
    public Fade cube2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ParallelCoroutine();
        }
    }

    void ParallelCoroutine()
    {
        StartCoroutine(cube0.FadeOut());
        StartCoroutine(cube1.FadeOut());
        StartCoroutine(cube2.FadeOut());
    }
}
