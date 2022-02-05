using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
    private float[] spectrum = new float[128];
    public static float value { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Hanning);
        if (spectrum != null && spectrum.Length > 0f)
        {
            value = spectrum[0] * 100;
        }
    }
}
