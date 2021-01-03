using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class results : MonoBehaviour
{
    [SerializeField] GameObject modello1;
    [SerializeField] GameObject modello2;
    [SerializeField] GameObject modello3;

    [SerializeField] GameObject[] haisrtyles_container1;
    [SerializeField] GameObject[] haisrtyles1;

    [SerializeField] GameObject[] haisrtyles_container2;
    [SerializeField] GameObject[] haisrtyles2;

    [SerializeField] GameObject[] haisrtyles_container3;
    [SerializeField] GameObject[] haisrtyles3;

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
            haisrtyles_container1[i].SetActive(false);
            haisrtyles_container2[i].SetActive(false);
            haisrtyles_container3[i].SetActive(false);
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
                haisrtyles_container1[0].SetActive(true);
                break;

            case 1:
                haisrtyles_container1[1].SetActive(true);
                break;

            case 2:
                haisrtyles_container1[2].SetActive(true);
                break;
        }

        switch (m2.blendshapes[86])
        {
            case 0:
                haisrtyles_container2[0].SetActive(true);
                break;

            case 1:
                haisrtyles_container2[1].SetActive(true);
                break;

            case 2:
                haisrtyles_container2[2].SetActive(true);
                break;
        }

        switch (m3.blendshapes[86])
        {
            case 0:
                haisrtyles_container3[0].SetActive(true);
                break;

            case 1:
                haisrtyles_container3[1].SetActive(true);
                break;

            case 2:
                haisrtyles_container3[2].SetActive(true);
                break;
        }

        //colore capelli
        switch (m1.blendshapes[87])
        {
            case 0:
                haisrtyles1[0].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles1[1].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles1[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                haisrtyles1[0].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles1[1].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles1[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                haisrtyles1[0].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles1[1].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles1[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                haisrtyles1[0].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles1[1].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles1[2].GetComponent<Renderer>().material = hairstyles_color[3];
                break;
        }

        switch (m2.blendshapes[87])
        {
            case 0:
                haisrtyles2[0].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles2[1].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles2[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                haisrtyles2[0].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles2[1].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles2[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                haisrtyles2[0].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles2[1].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles2[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                haisrtyles2[0].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles2[1].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles2[2].GetComponent<Renderer>().material = hairstyles_color[3];
                break;
        }

        switch (m3.blendshapes[87])
        {
            case 0:
                haisrtyles3[0].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles3[1].GetComponent<Renderer>().material = hairstyles_color[0];
                haisrtyles3[2].GetComponent<Renderer>().material = hairstyles_color[0];
                break;

            case 1:
                haisrtyles3[0].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles3[1].GetComponent<Renderer>().material = hairstyles_color[1];
                haisrtyles3[2].GetComponent<Renderer>().material = hairstyles_color[1];
                break;

            case 2:
                haisrtyles3[0].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles3[1].GetComponent<Renderer>().material = hairstyles_color[2];
                haisrtyles3[2].GetComponent<Renderer>().material = hairstyles_color[2];
                break;

            case 3:
                haisrtyles3[0].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles3[1].GetComponent<Renderer>().material = hairstyles_color[3];
                haisrtyles3[2].GetComponent<Renderer>().material = hairstyles_color[3];
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
