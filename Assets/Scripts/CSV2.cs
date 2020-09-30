using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Text;
using UnityEngine.UI;

public class CSV2 : MonoBehaviour
{
    string filePath = "C:\\UnityProjects\\NaszaLodowka\\Assets\\Resources\\example.csv";

    public void GetForms()
    {
        //znajdz produkt
        Input1 input1 = FindObjectOfType<Input1>();
        Input2 input2 = FindObjectOfType<Input2>();
        Input3 input3 = FindObjectOfType<Input3>();
        string produkt = (input1.GetComponent<InputField>().text);
        string ilosc = (input2.GetComponent<InputField>().text);
        string opis = (input3.GetComponent<InputField>().text);

        SaveCSV(produkt, ilosc, opis);
    }
    //string produkt, int ilosc, string opis
    public void SaveCSV(string produkt, string ilosc, string opis)
    {

        //int length = output.GetLength(0);
        string delimiter = ";";
        string sb = "";
        bool nowyProdukt = true;

        TextAsset data = Resources.Load("example") as TextAsset;
        string[] lines = data.text.Split("\n"[0]);
        Debug.Log("ilosc linii = " + lines.Length);



        for (var i = 0; i<lines.Length; i++)
        {
            if (i + 1 == lines.Length)
            {
                if (lines[i] == "")
                {
                    Debug.Log("Empty line " + i);
                }
                else
                {
                    string[] parts = lines[i].Split(delimiter[0]);

                    for (var j = 0; j < parts.Length; j++)
                    {
                        Debug.Log("Line " + i + ", part " + j + " = " + parts[j]);
                    }
                    if (parts[0] == produkt)
                    {
                        Debug.Log("jest produkt");
                        nowyProdukt = false;
                        parts[1] = ilosc;
                        parts[2] = opis;
                        lines[i] = parts[0] + delimiter + parts[1] + delimiter + parts[2]; //TODO: zamienić na pętlę po wszystkich parts
                        sb = sb + lines[i];
                    }
                    else
                    {
                        sb = sb + lines[i];
                    }
                }
            }
            else
            {
                if (lines[i] == "")
                {
                    Debug.Log("Empty line " + i);
                }
                else
                {
                    string[] parts = lines[i].Split(delimiter[0]);

                    for (var j = 0; j < parts.Length; j++)
                    {
                        Debug.Log("Line " + i + ", part " + j + " = " + parts[j]);
                    }
                    if (parts[0] == produkt)
                    {
                        Debug.Log("jest produkt");
                        nowyProdukt = false;
                        parts[1] = ilosc;
                        parts[2] = opis;
                        lines[i] = parts[0] + delimiter + parts[1] + delimiter + parts[2]; //TODO: zamienić na pętlę po wszystkich parts
                        sb = sb + lines[i] + "\n";
                    }
                    else
                    {
                        sb = sb + lines[i] + "\n";
                    }
                }
            }      
        }

        if (nowyProdukt == true)
        {
            Debug.Log("Nowy produkt");
            sb = sb + "\n" + produkt + delimiter + ilosc + delimiter + opis;
        }
        else
        {
            Debug.Log("Istniejacy produkt");
        }

        StreamWriter outStream = System.IO.File.CreateText(filePath);
        //FileStream outStream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Write, FileShare.None); // dla Open() trzeba podać inny write
        outStream.Write(sb);
        outStream.Close();



    }

}
