using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    [SerializeField] private GameObject newSession;
    [SerializeField] private GameObject resumeSession;
    [SerializeField] private GameObject save;

    private void Start()
    {
        if(PlayerPrefs.GetString("saves") == null)
        {
            resumeSession.SetActive(false);
            save.SetActive(false);
        }
    }
}
