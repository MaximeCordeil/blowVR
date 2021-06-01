using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MicBoxResizer : MonoBehaviour
{
    public AnimationCurve blowCurve;

    private List<float> values = new List<float>();

    public void MicInputChanged(float value)
    {
        var v = blowCurve.Evaluate(value);

        var s = transform.localScale;
        s.x = 0.5f + v;
        s.y = 0.5f + v;
        s.z = 0.5f + v;
        transform.localScale = s;
        
        GetComponent<Renderer>().material.color = Color.Lerp(Color.white, Color.red, v);
    }

}
