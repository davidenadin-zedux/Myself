using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragazza : MonoBehaviour
{
    private float[] blendshapes;
    private float[] modifications;

    public void setBlendshape(int index, float value)
    {
        blendshapes[index] = value;
    }

    public void setModification(int index, float value)
    {
        modifications[index] = value;
    }

    public float getBlendshape(int index)
    {
        return blendshapes[index];
    }

    public float getModification(int index)
    {
        return modifications[index];
    }
}
