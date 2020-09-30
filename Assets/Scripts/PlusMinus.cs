using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlusMinus : MonoBehaviour
{

    bool Active = false;
    AmountScript currentAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentAmount = FindObjectOfType<AmountScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Clicked();
    }

    void Clicked()
    {
        if (Input.GetMouseButtonDown(0) && Active && this.name == "PlusButton")
        {
            
            Debug.Log(this.name + "clicked Plus");
            currentAmount.GetComponent<TextMeshPro>().text = "1";
        }
        else if (Input.GetMouseButtonDown(0) && Active && this.name == "MinusButton")
        {
            Debug.Log(this.name + "clicked Minus");
            currentAmount.GetComponent<TextMeshPro>().text = "-1";
        }
    }

    private void OnMouseOver()
    {
        Active = true;
    }

    private void OnMouseExit()
    {
        Active = false;
    }

}
