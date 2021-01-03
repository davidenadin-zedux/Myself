using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    static Modello m1 = new Modello();
    static Modello m2 = new Modello();
    static Modello m3 = new Modello();

    [SerializeField] GameObject modello;

    [SerializeField] GameObject GameManager;

    [SerializeField] GameObject[] hairstyles_forpos;
    [SerializeField] GameObject[] hairstyles_forcol;

    [SerializeField] Material[] hairstyles_color;

    [SerializeField] Material[] skin_color;

    private float offset = 0.007097f;
    private float offset1 = 0;

    Modello m = new Modello();

    public void nextScene()
    {   
        if(SceneManager.GetActiveScene().buildIndex < 3)
        {
            save();
        } else {
            save();
            PlayerPrefs.SetString("saves1", JsonUtility.ToJson(m1));
            PlayerPrefs.SetString("saves2", JsonUtility.ToJson(m2));
            PlayerPrefs.SetString("saves3", JsonUtility.ToJson(m3));
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void save()
    {
        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                //blendshapes
                for (int i = 0; i < 86; i++) {
                    m1.blendshapes[i] = modello.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(i);
                }

                //acconciatura
                for (int i = 0; i < 3; i++)
                {
                    if (hairstyles_forpos[i].activeSelf == true)
                    {
                        m1.blendshapes[86] = i;
                    }
                }

                //color capelli
                for (int i = 0; i < hairstyles_color.Length; i++)
                {
                    if (hairstyles_forcol[0].GetComponent<MeshRenderer>().material.name.Split(' ')[0] == hairstyles_color[i].name)
                    {
                        m1.blendshapes[87] = i;
                    }
                }

                //colore pelle
                for (int i = 0; i < skin_color.Length; i++)
                {
                    if (modello.GetComponent<SkinnedMeshRenderer>().material.name.Split(' ')[0] == skin_color[i].name)
                    {
                        m1.blendshapes[88] = i;
                    }
                }
                break;

            case 2:
                //blendshapes
                for (int i = 0; i < 86; i++)
                {
                    m2.blendshapes[i] = modello.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(i);
                }

                //acconciatura
                for (int i = 0; i < 3; i++)
                {
                    if (hairstyles_forpos[i].activeSelf == true)
                    {
                        m2.blendshapes[86] = i;
                    }
                }

                //color capelli
                for (int i = 0; i < hairstyles_color.Length; i++)
                {
                    if (hairstyles_forcol[0].GetComponent<MeshRenderer>().material.name.Split(' ')[0] == hairstyles_color[i].name)
                    {
                        m2.blendshapes[87] = i;
                    }
                }

                //colore pelle
                for (int i = 0; i < skin_color.Length; i++)
                {
                    if (modello.GetComponent<SkinnedMeshRenderer>().material.name.Split(' ')[0] == skin_color[i].name)
                    {
                        m2.blendshapes[88] = i;
                    }
                }
                break;

            case 3:
                //blendshapes
                for (int i = 0; i < 86; i++)
                {
                    m3.blendshapes[i] = modello.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(i);
                }

                //acconciatura
                for (int i = 0; i < 3; i++)
                {
                    if (hairstyles_forpos[i].activeSelf == true)
                    {
                        m3.blendshapes[86] = i;
                    }
                }

                //color capelli
                for (int i = 0; i < hairstyles_color.Length; i++)
                {
                    if (hairstyles_forcol[0].GetComponent<MeshRenderer>().material.name.Split(' ')[0] == hairstyles_color[i].name)
                    {
                        m3.blendshapes[87] = i;
                    }
                }

                //colore pelle
                for (int i = 0; i < skin_color.Length; i++)
                {
                    if (modello.GetComponent<SkinnedMeshRenderer>().material.name.Split(' ')[0] == skin_color[i].name)
                    {
                        m3.blendshapes[88] = i;
                    }
                }
                break;
        }
    }
}

[System.Serializable]
public class Modello
{
    public float[] blendshapes = new float[91];
}
