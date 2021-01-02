using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class results : MonoBehaviour
{
    [SerializeField] GameObject modello1;
    [SerializeField] GameObject modello2;
    [SerializeField] GameObject modello3;

    [SerializeField] GameObject[] hairstyles_forpos1;
    [SerializeField] GameObject[] hairstyles_forcol1;

    [SerializeField] GameObject[] hairstyles_forpos2;
    [SerializeField] GameObject[] hairstyles_forcol2;

    [SerializeField] GameObject[] hairstyles_forpos3;
    [SerializeField] GameObject[] hairstyles_forcol3;

    [SerializeField] Material[] hairstyles_color;

    [SerializeField] Material[] skin_color;

    Modello m1 = new Modello();
    Modello m2 = new Modello();
    Modello m3 = new Modello();

    private float offset = 0.007096f;
    private float offset1 = 0;

    void Start()
    {
        for(int i=0; i<3; i++)
        {
            hairstyles_forpos1[i].SetActive(false);
            hairstyles_forpos2[i].SetActive(false);
            hairstyles_forpos3[i].SetActive(false);
        }

        m1 = (JsonUtility.FromJson<Modello>(PlayerPrefs.GetString("saves1")));
        m2 = (JsonUtility.FromJson<Modello>(PlayerPrefs.GetString("saves2")));
        m3 = (JsonUtility.FromJson<Modello>(PlayerPrefs.GetString("saves3")));


        for (int i = 0; i < 86; i++)
        {
            modello1.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, m1.blendshapes[i]);
            modello2.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, m2.blendshapes[i]);
            modello3.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, m3.blendshapes[i]);
        }

        switch(m1.blendshapes[86])
        {
            case 0:
                hairstyles_forpos1[0].SetActive(true);
                break;

            case 1:
                hairstyles_forpos1[1].SetActive(true);
                break;

            case 2:
                hairstyles_forpos1[2].SetActive(true);
                break;
        }

        switch (m2.blendshapes[86])
        {
            case 0:
                hairstyles_forpos2[0].SetActive(true);
                break;

            case 1:
                hairstyles_forpos2[1].SetActive(true);
                break;

            case 2:
                hairstyles_forpos2[2].SetActive(true);
                break;
        }

        switch (m3.blendshapes[86])
        {
            case 0:
                hairstyles_forpos3[0].SetActive(true);
                break;

            case 1:
                hairstyles_forpos3[1].SetActive(true);
                break;

            case 2:
                hairstyles_forpos3[2].SetActive(true);
                break;
        }

        //modello 1 pos parrucca
        for (int i = 0; i < 3; i++)
        {
            if (m1.blendshapes[89] < 0)
            {
                hairstyles_forpos1[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00003528f * (m1.blendshapes[89] + 50) + 0.005332f - offset1);
                offset = 0.00003528f * (m1.blendshapes[89] + 50) + 0.005332f;
            }
            else
            {
                hairstyles_forpos1[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.000068f * m1.blendshapes[89] + 0.007096f - offset1);
                offset = 0.000068f * m1.blendshapes[89] + 0.007096f;
            }

            hairstyles_forpos1[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, offset - 0.0000063f * m1.blendshapes[90]);
            offset1 = 0.0000063f * m1.blendshapes[90];
        }

        offset = 0.007096f;
        offset1 = 0;

        //modello 2 pos parrucca
        for (int i = 0; i < 3; i++)
        {
            if (m2.blendshapes[89] < 0)
            {
                hairstyles_forpos2[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00003528f * (m2.blendshapes[89] + 50) + 0.005332f - offset1);
                offset = 0.00003528f * (m1.blendshapes[89] + 50) + 0.005332f;
            }
            else
            {
                hairstyles_forpos2[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.000068f * m2.blendshapes[89] + 0.007096f - offset1);
                offset = 0.000068f * m2.blendshapes[89] + 0.007096f;
            }

            hairstyles_forpos2[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, offset - 0.0000063f * m2.blendshapes[90]);
            offset1 = 0.0000063f * m2.blendshapes[90];
        }

        offset = 0.007096f;
        offset1 = 0;

        //modello 3 pos parrucca
        for (int i = 0; i < 3; i++)
        {
            if (m3.blendshapes[89] < 0)
            {
                hairstyles_forpos3[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.00003528f * (m3.blendshapes[89] + 50) + 0.005332f - offset1);
                offset = 0.00003528f * (m3.blendshapes[89] + 50) + 0.005332f;
            }
            else
            {
                hairstyles_forpos3[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, 0.000068f * m3.blendshapes[89] + 0.007096f - offset1);
                offset = 0.000068f * m3.blendshapes[89] + 0.007096f;
            }

            hairstyles_forpos3[i].transform.localPosition = new Vector3(0.0001269094f, -0.00059f, offset - 0.0000063f * m3.blendshapes[90]);
            offset1 = 0.0000063f * m3.blendshapes[90];
        }

        offset = 0.007096f;
        offset1 = 0;


        //colore capelli
        switch (m1.blendshapes[87])
        {
            case 0:
                hairstyles_forcol1[0].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol1[1].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol1[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                hairstyles_forcol1[0].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol1[1].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol1[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                hairstyles_forcol1[0].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol1[1].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol1[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                hairstyles_forcol1[0].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol1[1].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol1[2].GetComponent<Renderer>().material = hairstyles_color[3];
                break;
        }

        switch (m2.blendshapes[87])
        {
            case 0:
                hairstyles_forcol2[0].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol2[1].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol2[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                hairstyles_forcol2[0].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol2[1].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol2[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                hairstyles_forcol2[0].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol2[1].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol2[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                hairstyles_forcol2[0].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol2[1].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol2[2].GetComponent<Renderer>().material = hairstyles_color[3];
                break;
        }

        switch (m3.blendshapes[87])
        {
            case 0:
                hairstyles_forcol3[0].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol3[1].GetComponent<Renderer>().material = hairstyles_color[0];
                hairstyles_forcol3[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                hairstyles_forcol3[0].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol3[1].GetComponent<Renderer>().material = hairstyles_color[1];
                hairstyles_forcol3[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                hairstyles_forcol3[0].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol3[1].GetComponent<Renderer>().material = hairstyles_color[2];
                hairstyles_forcol3[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                hairstyles_forcol3[0].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol3[1].GetComponent<Renderer>().material = hairstyles_color[3];
                hairstyles_forcol3[2].GetComponent<Renderer>().material = hairstyles_color[3];
                break;
        }

        switch (m1.blendshapes[88])
        {
            case 0:
                modello1.GetComponent<Renderer>().material = skin_color[0];
                break;

            case 1:
                modello1.GetComponent<Renderer>().material = skin_color[1];
                break;

            case 2:
                modello1.GetComponent<Renderer>().material = skin_color[2];
                break;

            case 3:
                modello1.GetComponent<Renderer>().material = skin_color[3];
                break;
        }

        switch (m2.blendshapes[88])
        {
            case 0:
                modello2.GetComponent<Renderer>().material = skin_color[0];
                break;

            case 1:
                modello2.GetComponent<Renderer>().material = skin_color[1];
                break;

            case 2:
                modello2.GetComponent<Renderer>().material = skin_color[2];
                break;

            case 3:
                modello2.GetComponent<Renderer>().material = skin_color[3];
                break;
        }

        switch (m3.blendshapes[88])
        {
            case 0:
                modello3.GetComponent<Renderer>().material = skin_color[0];
                break;

            case 1:
                modello3.GetComponent<Renderer>().material = skin_color[1];
                break;

            case 2:
                modello3.GetComponent<Renderer>().material = skin_color[2];
                break;

            case 3:
                modello3.GetComponent<Renderer>().material = skin_color[3];
                break;
        }
    }
}
