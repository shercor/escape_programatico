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
    string[] A = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] B = new string[] {"AAA", "B", "334", "HOLA", "XD"};
    string[] C = new string[] {"AAA", "B", "334", "HOLA", "XD"};
    string[] D = new string[] {"AAA", "B", "334", "HOLA", "XD"};
    string[] E = new string[] {"AAA", "B", "334", "HOLA", "XD"};
    string[] F = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] G = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] H = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] I = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] J = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] K = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] L = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] M = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] N = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] O = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] P = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] Q = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] R = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] S = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] T = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] U = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] V = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOEEEEASDASD", "KYLIE"};
    string[] W = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] X = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] Y = new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
    string[] Z = new string[] {"AAAAAAAAA", "BBBB", "334333", "HOLAAAA", "XDDD","VacaAAA", "KAZULLLL", "KIARAEEE", "KHLOEEEEASDASD", "KYLIEEE"};
    string[][] letras = new string[][]{};
    string[] abecedario = new string[]
    {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
        "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
    };
    string[][] abecedario2 = new string[][]
    {
        /* A */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //A
        /* B */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //B
        /* C */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //C
        /* D */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //D
        /* E */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //E
        /* F */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //F
        /* G */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //G
        /* H */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //H
        /* I */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //I
        /* J */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //J
        /* K */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //K
        /* L */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //L
        /* M */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //M
        /* N */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //N
        /* O */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //O
        /* P */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //P
        /* Q */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //Q
        /* R */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //R
        /* S */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //S
        /* T */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //T
        /* U */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //U
        /* V */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //V
        /* W */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOEEEEEEE", "KYLIE"}, //W
        /* X */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //X
        /* Y */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //Y
        /* Z */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"} //Z
    };

    int j = 0;
    string temp;
    private string code = "Debug.Log(\"Hola xDXDXD\");";
    string tipo;
    void Start()
    {
        string[][] letras = {A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z};
        Debug.Log("El largo de letras es: " + letras.Length);
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
                if (i == 0){
                    tipo = child.gameObject.transform.GetChild(0).tag;
                }
                Debug.Log(child.name);
                
                Debug.Log("El tag del bloque es: " + child.gameObject.transform.GetChild(0).tag);
                
                Debug.Log("Bloque: " + i);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).name);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).name);
                //Debug.Log(child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).name);
                T1 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                T2 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                T3 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
                //Debug.Log(T1.text);
                //Debug.Log(T2.text);
                //Debug.Log(T3.text);
                //Debug.Log("" + T1.text+ "" + T2.text+ "" + T3.text);
                temp = T1.text + T2.text + T3.text;
                Debug.Log(temp);
                lines[j] = lines[j] + temp;
                Debug.Log("Frase de Linea " + j + ": " + lines[j]);
            }
            i = i + 1;
            if (i == 6){
                i = 0;
                compilador(lines[j], tipo);
                lines[j] = "";
                break;  
                j = j + 1;     
                //ExecuteCode(code);
            }
            //i = i + 1;
            // Acceder a cada hijo y realizar las operaciones necesarias
        }
        j = 0;
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

    private void compilador(string mensaje, string tipo){
        if (tipo == "print"){
            mensaje = RemoveStringStart(mensaje, "print(");
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                blockPrint(mensaje);
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
            
        }
        else {
            Debug.Log("No tenemos la orden de printear");
        }
    }

    private void blockPrint(string mensaje){
        Debug.Log("Debo printear algo");
        Debug.Log("El mensaje es: " + mensaje);
        string res = string.Join(" ", A);
        Debug.Log(res);
        Debug.Log(A[1]);
        Debug.Log(AnalisisCorchetes(mensaje));
        SeparadorComa(mensaje);
    }



    /*------------------------------------------------------------- Funciones auxiliares para la funcionalidad de PRINT -------------------------------------------------------------*/


    //Remueve un Substring dado del inicio de un String
    public string RemoveStringStart(string originalString, string substringToRemove)
    {
        if (originalString.StartsWith(substringToRemove))
        {
            return originalString.Substring(substringToRemove.Length);
        }

        return originalString;
    }


    //Remueve un Substring dado del final de un String
    public string RemoveStringEnd(string originalString, string substringToRemove)
    {
        if (originalString.EndsWith(substringToRemove))
        {
            return originalString.Substring(0, originalString.Length - substringToRemove.Length);
        }

        return originalString;
    }

    public bool CompareEndOfStringsWithSubstring(string[] strings, string substring)
    {
        foreach (string str in strings)
        {
            if (!str.EndsWith(substring))
            {
                return false;
            }
        }
        return true;
    }

    //Verifica si un String termina con un Substring dado
    public bool CompareEndOfStringsWithSubstring2(string str, string substring)
    {
        return str.EndsWith(substring);
    }

    //Printea todos los elementos de un String separados por comas
    private void SeparadorComa(string inputString){
        string[] substrings = inputString.Split(',');
        foreach (string substring in substrings)
        {
            Debug.Log(substring);
            AnalisisComa(substring);
            Console.WriteLine(substring.Trim());
        }
    }

    private void AnalisisComa(string substring){
        if (AnalisisCorchetes(substring).Item1 == true){
            try{
                Debug.Log(substring[0]);
                Debug.Log("Z");
                int num = Array.IndexOf(abecedario, "Z");
            } catch {
            }
            Debug.Log("Veremos si el primer caracter de " + substring +  "es una letra");
            string letter = substring[0].ToString();
            bool aux = Array.Exists(abecedario, element => element.Equals(letter));
            if (aux) {
                Debug.Log("ES UNA LETRA");
                Debug.Log(letter + " es un Arreglo");
            } else {
                Debug.Log("NO LO ES");
                letter = substring[1].ToString();
                Debug.Log(letter + " es un Arreglo");
            }
            //Debug.Log(substring[1] + " es un Arreglo");
            
            int ind1 = AnalisisCorchetes(substring).Item2 + 1;
            Debug.Log("Primer corchete está en: " + AnalisisCorchetes(substring).Item2);
            Debug.Log("Segundo corchete está en: " + AnalisisCorchetes(substring).Item3);

            if (AnalisisCorchetes(substring).Item2 + 1 != AnalisisCorchetes(substring).Item3){
                string aver = ObtenerSubstring(substring, AnalisisCorchetes(substring).Item2 + 1, AnalisisCorchetes(substring).Item3);
                int indice = int.Parse(aver);
                int numLetra = Array.IndexOf(abecedario, letter);
                Debug.Log("La letra " + letter + " está en la posición " + numLetra + " del abecedario");
                Debug.Log(numLetra);
                Debug.Log(indice);
                Debug.Log(letras.Length);
                Debug.Log("El contenido de la lista" + substring + "es: " + abecedario2[numLetra][indice]);
            } else {
                Debug.Log("No hay nada dentro :()");
            }
        }
    }

    //Función para ver si hay [] en un string
    static (bool, int, int) AnalisisCorchetes(string cadena)
    {
        int indicePrimerCorcheteAbierto = cadena.IndexOf("[");
        int indicePrimerCorcheteCerrado = cadena.IndexOf("]");
        bool estanEnOrden = indicePrimerCorcheteAbierto != -1 && indicePrimerCorcheteCerrado != -1 && indicePrimerCorcheteAbierto < indicePrimerCorcheteCerrado;
        return (estanEnOrden, indicePrimerCorcheteAbierto, indicePrimerCorcheteCerrado);
    }

    //Obtiene un substring que parte desde el primer indice y termina justo antes del indice fin
    static string ObtenerSubstring(string cadena, int indiceInicio, int indiceFin)
    {
        int longitud = indiceFin - indiceInicio;
        return cadena.Substring(indiceInicio, longitud);
    }

}
