using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scena_manager : MonoBehaviour
{
    [SerializeField] GameObject modello;
    private Ragazza[] modelli;

    private int min, max;

    void Start()
    {
        modelli = new Ragazza[3];

        if(PlayerPrefs.HasKey("save"))
        {
            for(int i=0; i<modelli.Length; i++)
            {

            }
        }
    }

    public void setMin(int min)
    {
        this.min = min;
    }

    public void setMax(int max)
    {
        this.max = max;
    }

    public void applyBlendShape(float value)
    {
        modello.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(max, value);
    }

}
