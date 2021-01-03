using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairManager : MonoBehaviour
{
    [SerializeField] GameObject modello;
    [SerializeField] GameObject[] Hairstyles;

    private Mesh tempMesh;
    private Vector3 pos;

    private void Start()
    {
        tempMesh = new Mesh();
    }
    void Update()
    {
        modello.GetComponent<SkinnedMeshRenderer>().BakeMesh(tempMesh);
        
        pos = tempMesh.vertices[881];
        
        pos = modello.GetComponent<SkinnedMeshRenderer>().transform.TransformPoint(pos);



        for(int i=0; i<Hairstyles.Length; i++) { 
            Hairstyles[i].transform.position = pos;
        }
    }
}
