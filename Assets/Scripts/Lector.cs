using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

public class Lector : MonoBehaviour
{
    public Image grid;
    private int i;
    private string t1, t2, t3;
    // Start is called before the first frame update
    public TextMeshProUGUI T1;
    public TextMeshProUGUI T2;
    public TextMeshProUGUI T3;
    string[] lines = new string[6];
    int j = 0;
    string temp;
    private string code = "Debug.Log(\"Hola xDXDXD\");";

    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Contador()
    {
        Debug.Log(grid.gameObject.transform.childCount);
        foreach (Transform child in grid.gameObject.transform)
        {
            if (i<9 && child.childCount != 0){
                Debug.Log(child.name);
                Debug.Log("Bloque: " + i);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).name);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).name);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).name);
                T1 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                T2 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                T3 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
                Debug.Log(T1.text);
                Debug.Log(T2.text);
                Debug.Log(T3.text);
                //Debug.Log("" + T1.text+ "" + T2.text+ "" + T3.text);
                temp = T1.text + T2.text + T3.text;
                Debug.Log(temp);
                lines[j] = lines[j] + temp;
                Debug.Log(lines[j]);
            }
            i = i + 1;
            if (i == 9){
                //i = 0;
                //j = j + 1;    
                ExecuteCode(code);
            }


            
            //i = i + 1;
            // Acceder a cada hijo y realizar las operaciones necesarias
        }
        //Debug.Log(i);
    }

    private void ExecuteCode(string code)
    {
        try
        {
            System.Reflection.Assembly assembly = typeof(GameObject).Assembly;
            System.Type debugType = assembly.GetType("UnityEngine.Debug");
            System.Reflection.MethodInfo logMethod = debugType.GetMethod("Log", new[] { typeof(object) });

            // Crea un objeto Debug para utilizar como el objeto "this" en el método Log
            UnityEngine.Debug debugInstance = new UnityEngine.Debug();

            // Ejecuta el código pasándole el objeto Debug como el objeto "this"
            logMethod.Invoke(debugInstance, new object[] { "XD" });
        }
        catch (Exception ex)
        {
            Debug.LogError("Error al ejecutar el código: " + ex.Message);
        }
    }

}
