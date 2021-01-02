using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    [SerializeField] private GameObject modello;

    static float[] save_shapes1 = new float[86];

    private static int currentScene = -1;

    private void Start()
    {

        if (currentScene == 1)
        {
            if(PlayerPrefs.GetString("saves") != null)
            {
                save_shapes1 = JsonUtility.FromJson<float[]>(PlayerPrefs.GetString("saves"));
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            for(int i=0; i<86; i++)
            {
                modello.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, save_shapes1[i]);
                //modello2.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, save_shapes[1, i]);
                //modello3.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(i, save_shapes[2, i]);
            }
        }
    }

    public void nextScene()
    {
        save();
  
        switch(SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                SceneManager.LoadScene(2);
                break;

            case 2:
                SceneManager.LoadScene(3);
                break;
        }
    }

    void save()
    {
        for (int i = 0; i < 86; i++)
        {
            save_shapes1[i] = 23f;
        }
    }

    public void newSession()
    {
        PlayerPrefs.DeleteAll();

        SceneManager.LoadScene(1);
    }

    public void resume()
    {
        SceneManager.LoadScene(1);
    }

    public void lastRest()
    {
        SceneManager.LoadScene(4);
    }
}