using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    [Range(1f, 10f)]
    public float duration = 5f;
    public Renderer renderer;
    
    bool _lock = false;

    void Awake ()
    {
        renderer = this.GetComponent<Renderer>();
    }

    public IEnumerator FadeOut()
    {
        if(_lock || renderer.material.color.a <= 0f)
            yield break;

        _lock = true; 
        {
            float period = 0.02f;
            int times = Mathf.RoundToInt(duration / period);
            float alphaOffset = renderer.material.color.a / (float)times;

            Color c = renderer.material.color;
            for (float alpha = 1f; alpha > 0; alpha -= alphaOffset)
            {
                c.a = alpha;
                renderer.material.color = c;
                yield return new WaitForSeconds(period);
                duration -= period;
            }
            c.a = 0;
            renderer.material.color = c;
            duration = 0f;
        }
        _lock = false;
    }
}
