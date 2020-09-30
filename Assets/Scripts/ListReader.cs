using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;
using TMPro;

public class ListReader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string filePath = "C:\\UnityProjects\\NaszaLodowka\\Assets\\Resources\\example.csv";

        //FileStream outStream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Write, FileShare.None);
        string sb = "";
        TextAsset data = Resources.Load("example") as TextAsset;
        string[] lines = data.text.Split("\n"[0]);

        for (var i = 0; i < lines.Length; i++)
        {
            sb = sb + lines[i];
        }

        this.GetComponent<TextMeshPro>().text = sb;
    }
}
