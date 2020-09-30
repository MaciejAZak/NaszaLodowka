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
        UpdateCSVRead();
    }

    public void UpdateCSVRead()
    {
        string filePath = "C:\\UnityProjects\\NaszaLodowka\\Assets\\Resources\\example.csv";
        string sb = "";

        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                sb = sb + line;

            }
        }

        Debug.Log(sb);
        this.GetComponent<TextMeshPro>().text = sb;
    }

    // Update is called once per frame
    void Update()
    {


        //
        //TextAsset data = Resources.Load("example") as TextAsset;
        //string[] lines = data.text.Split("\n"[0]);
        //
        //for (var i = 0; i < lines.Length; i++)
        //{
        //    sb = sb + lines[i];
        //}
        //
        //
    }
}
