using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public Fade cube;
    public TMP_Text alpha;
    public TMP_Text time;

    // Update is called once per frame
    void Update()
    {
        alpha.text = string.Format("alpha: {0:#0.00}", cube.renderer.material.color.a);
        time.text = string.Format("{0:#0.00}s", cube.duration);
    }
}
