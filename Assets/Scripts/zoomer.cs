using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomer : MonoBehaviour
{
    private Animator animator;
    private int focus = 0, prefocus = 0;

    public GameObject modello;
    public GameObject dropdown;
    public GameObject backButton;

    public GameObject proportions;
    public GameObject testa;
    public GameObject petto;
    public GameObject braccioSup;
    public GameObject braccioInf;
    public GameObject pancia;
    public GameObject gambaSup;
    public GameObject gambaInf;
    public Text title;

    public void setZone(int index)
    {
        switch (index)
        {
            case 0:
                title.text = "Myself";
                break;
            case 1:
                title.text = "Testa";
                break;
            case 2:
                title.text = "Seno";
                break;
            case 3:
                title.text = "Braccia inferiori";
                break;
            case 4:
                title.text = "Braccia superiori";
                break;
            case 5:
                title.text = "Vita";
                break;
            case 6:
                title.text = "Gambe superiori";
                break;
            case 7:
                title.text = "Gambe inferiori";
                break;
        }
    }
    void Start()
    {
        animator = modello.GetComponent<Animator>();

        dropdown.SetActive(true);
        backButton.SetActive(false);

        proportions.SetActive(true);
        testa.SetActive(false);
        petto.SetActive(false);
        braccioInf.SetActive(false);
        braccioSup.SetActive(false);
        pancia.SetActive(false);
        gambaSup.SetActive(false);
        gambaInf.SetActive(false);
    }

    public void changeFocus(int index)
    {
        prefocus = focus;
        focus = index;

        if (focus != 0)
        {
            dropdown.SetActive(false);
            backButton.SetActive(true);
        }
        else
        {
            dropdown.SetActive(true);
            backButton.SetActive(false);

            proportions.SetActive(true);
            testa.SetActive(false);
            petto.SetActive(false);
            braccioInf.SetActive(false);
            braccioSup.SetActive(false);
            pancia.SetActive(false);
            gambaSup.SetActive(false);
            gambaInf.SetActive(false);
        }

        switch (focus)
        {
            case 1:
                animator.Play("testa");

                proportions.SetActive(false);
                testa.SetActive(true);
                petto.SetActive(false);
                braccioInf.SetActive(false);
                braccioSup.SetActive(false);
                pancia.SetActive(false);
                gambaSup.SetActive(false);
                gambaInf.SetActive(false);
                break;
            case 2:
                animator.Play("petto");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(true);
                braccioInf.SetActive(false);
                braccioSup.SetActive(false);
                pancia.SetActive(false);
                gambaSup.SetActive(false);
                gambaInf.SetActive(false);
                break;
            case 3:
                animator.Play("braccioSup");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(false);
                braccioInf.SetActive(true);
                braccioSup.SetActive(false);
                pancia.SetActive(false);
                gambaSup.SetActive(false);
                gambaInf.SetActive(false);
                break;
            case 4:
                animator.Play("braccioInf");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(false);
                braccioInf.SetActive(false);
                braccioSup.SetActive(true);
                pancia.SetActive(false);
                gambaSup.SetActive(false);
                gambaInf.SetActive(false);
                break;
            case 5:
                animator.Play("vita");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(false);
                braccioInf.SetActive(false);
                braccioSup.SetActive(false);
                pancia.SetActive(true);
                gambaSup.SetActive(false);
                gambaInf.SetActive(false);
                break;
            case 6:
                animator.Play("gambaSup");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(false);
                braccioInf.SetActive(false);
                braccioSup.SetActive(false);
                pancia.SetActive(false);
                gambaSup.SetActive(true);
                gambaInf.SetActive(false);
                break;
            case 7:
                animator.Play("gambaInf");

                proportions.SetActive(false);
                testa.SetActive(false);
                petto.SetActive(false);
                braccioInf.SetActive(false);
                braccioSup.SetActive(false);
                pancia.SetActive(false);
                gambaSup.SetActive(false);
                gambaInf.SetActive(true);
                break;
        }

        animator.SetBool("back", false);
    }

    public void back()
    {
        animator.SetBool("back", true);

        changeFocus(0);


        switch (prefocus)
        {
            case 1:
                animator.Play("testa 0");
                break;
            case 2:
                animator.Play("petto 0");
                break;
            case 3:
                animator.Play("braccioSup 0");
                break;
            case 4:
                animator.Play("braccioInf 0");
                break;
            case 5:
                animator.Play("vita 0");
                break;
            case 6:
                animator.Play("gambaSup 0");
                break;
            case 7:
                animator.Play("gambaInf 0");
                break;
        }

        dropdown.GetComponent<Dropdown>().value = 0;
    }
}
