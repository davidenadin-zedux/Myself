using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colos_manager : MonoBehaviour
{
    private int color_index;
    [SerializeField] Renderer modello;
    [SerializeField] Material[] colors;
    [SerializeField] Material[] hair_colors;
    [SerializeField] MeshRenderer[] hairstyles;

    public void setTone(int col)
    {
        modello.material = colors[col];
    }


    public void setHairColor(int col)
    {
        color_index = col;

        for (int i = 0; i < hairstyles.Length; i++)
        {
            hairstyles[i].material = hair_colors[color_index];
        }
    }
}
