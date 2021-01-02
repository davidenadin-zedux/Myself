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

    private void Start()
    {
        if (PlayerPrefs.HasKey("saves1"))
        {
            for(int i = 0; i < 3; i++)
            {
                hairstyles_forpos[i].SetActive(false);
            }

            m = (JsonUtility.FromJson<Modello>(PlayerPrefs.GetString("saves" + SceneManager.GetActiveScene().buildIndex)));

            for (int i = 0; i < 86; i++)
            {
                modello.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, m.blendshapes[i]);
            }

            switch (m.blendshapes[86])
            {
                case 0:
                    hairstyles_forpos[0].SetActive(true);
                    break;

                case 1:
                    hairstyles_forpos[1].SetActive(true);
                    break;

                case 2:
                    hairstyles_forpos[2].SetActive(true);
                    break;
            }

            
            for(int i=0; i<3; i++)
            {
                if (m.blendshapes[89] < 0)
                {
                    hairstyles_forpos[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00003436f * (m.blendshapes[89] + 50) + 0.005379f - offset1);
                    offset = 0.00003436f * (m.blendshapes[89] + 50) + 0.005379f;
                }
                else
                {
                    hairstyles_forpos[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00006665f * m.blendshapes[89] + 0.007097f - offset1);
                    offset = 0.00006665f * m.blendshapes[89] + 0.007097f;
                }

                hairstyles_forpos[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, offset - 0.00000714f * m.blendshapes[90]);
                offset1 = 0.00000714f * m.blendshapes[90];
            }

            offset = 0.007096f;
            offset1 = 0;

            switch (m.blendshapes[87])
            {
                case 0:
                    hairstyles_forcol[0].GetComponent<Renderer>().material = hairstyles_color[0];
                    hairstyles_forcol[1].GetComponent<Renderer>().material = hairstyles_color[0];
                    hairstyles_forcol[2].GetComponent<Renderer>().material = hairstyles_color[0];
                    break;

                case 1:
                    hairstyles_forcol[0].GetComponent<Renderer>().material = hairstyles_color[1];
                    hairstyles_forcol[1].GetComponent<Renderer>().material = hairstyles_color[1];
                    hairstyles_forcol[2].GetComponent<Renderer>().material = hairstyles_color[1];
                    break;

                case 2:
                    hairstyles_forcol[0].GetComponent<Renderer>().material = hairstyles_color[2];
                    hairstyles_forcol[1].GetComponent<Renderer>().material = hairstyles_color[2];
                    hairstyles_forcol[2].GetComponent<Renderer>().material = hairstyles_color[2];
                    break;

                case 3:
                    hairstyles_forcol[0].GetComponent<Renderer>().material = hairstyles_color[3];
                    hairstyles_forcol[1].GetComponent<Renderer>().material = hairstyles_color[3];
                    hairstyles_forcol[2].GetComponent<Renderer>().material = hairstyles_color[3];
                    break;
            }

            switch (m.blendshapes[88])
            {
                case 0:
                    modello.GetComponent<Renderer>().material = skin_color[0];
                    break;

                case 1:
                    modello.GetComponent<Renderer>().material = skin_color[1];
                    break;

                case 2:
                    modello.GetComponent<Renderer>().material = skin_color[2];
                    break;

                case 3:
                    modello.GetComponent<Renderer>().material = skin_color[3];
                    break;
            }
        }
    }

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

                //pos parrucca
                m1.blendshapes[89] = blendshape.heightValue;

                m1.blendshapes[90] = blendshape.oldValue;
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

                //pos parrucca
                m2.blendshapes[89] = blendshape.heightValue;

                m2.blendshapes[90] = blendshape.oldValue;
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

                //pos parrucca
                m3.blendshapes[89] = blendshape.heightValue;

                m3.blendshapes[90] = blendshape.oldValue;
                break;
        }
    }
}

[System.Serializable]
public class Modello
{
    public float[] blendshapes = new float[91];
}
