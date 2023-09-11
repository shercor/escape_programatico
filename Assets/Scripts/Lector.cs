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
    public GameObject spawner;
    public GameObject PC;
    public Image grid;
    private int i;
    private string t1, t2, t3;
    // Start is called before the first frame update
    public TextMeshProUGUI T1;
    public TextMeshProUGUI T2;
    public TextMeshProUGUI T3;
    public TextMeshProUGUI pantalla;
    private GameObject controlador;
    public GameObject menos;
    public GameObject itemManager;
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
    string[] X = new string[] {"Silencio", "Bullicioso", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"};
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
        /* X */ new string[] {"AAA", "Bullicioso", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"}, //X
        /* Y */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARAaAWAW", "KHLOE", "KYLIE"}, //Y
        /* Z */ new string[] {"AAA", "B", "334", "HOLA", "XD","Vaca", "KAZUL", "KIARA", "KHLOE", "KYLIE"} //Z
    };
    private int mosca = 0;
    private static int raton = 1;
    private static int gato = 4;
    private static int perro = 5;
    string[] animales = {"mosca", "rata", "gato", "perro", "pez"};
    int[] animalesValores = {0, 2, 4, 5, 0};
    string[] dispositivos = {"azul", "verde", "lila","rosa", "rojo"};
    int[] dispositivosClaves = {5, 20, 6, 1000, 1};

    int j = 0;
    string temp;
    private string code = "Debug.Log(\"Hola xDXDXD\");";
    string tipo;
    bool vacio = false;
    bool bloqueLlave = false;
    bool bloqueMenos = false;
    int iteracion = 0;
    

    void Start()
    {
        controlador = GameObject.FindWithTag("dispositivos");
        string[][] letras = {A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z};
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Contador() //Procesa el contenido en los bloques
    {
        
        pantalla.text = "";
        //Debug.Log(grid.gameObject.transform.childCount);
        foreach (Transform child in grid.gameObject.transform)
        {
            if (i<9 && child.childCount != 0){
                Debug.Log(i + "," + j + " Hijos: ->" +  child.childCount +  child.name);
                Debug.Log(i);
                if (i == 0){
                    
                    tipo = child.gameObject.transform.GetChild(0).tag;
                    Debug.Log(tipo);
                }
                T1 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
                T2 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
                T3 = child.gameObject.transform.GetChild(0).gameObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
                temp = T1.text + T2.text + T3.text;
                lines[j] = lines[j] + temp;
            } else if (i == 0 && child.childCount == 0){ //CUIDADO
                //i = 0;
                //Debug.Log("SE VA A CORTAR TODO... " + i + "," +j + " Hijos: ->" +  child.childCount +  child.name);
                if (pantalla.text == "7\n9\n2\n6\n0\n"){
                    Debug.Log("CONSEGUIDO FELICIDADES");
                    spawner = GameObject.FindWithTag("Spawner");
                    Debug.Log("Hola");
                    spawner.GetComponent<Spawner>().color(PC.transform.position + new Vector3(2f,2f,0F));
                    itemManager = GameObject.FindWithTag("itemManager");
                    itemManager.GetComponent<ItemManager>().upColor();
                    bloqueLlave = true;

                }
                if (pantalla.text == "9\n6\n0\n" && bloqueMenos == false){
                    Debug.Log("CONSEGUIDO FELICIDADES");
                    spawner = GameObject.FindWithTag("Spawner");
                    Debug.Log("Hola");
                    spawner.GetComponent<Spawner>().spawnear(menos, PC.transform.position + new Vector3(2f,2f,0F));
                    bloqueMenos = true;
                }
                //return; //SE CORTA APENAS DETECTA UNA LINEA VACÍA, ARREGLAR
                //vacio = true;
            }
            i = i + 1;
            if (i == 6 && vacio == false){
                i = 0;
                //Debug.Log(j + tipo);
                compilador(lines[j], tipo);
                //Debug.Log("Siguiente");
                lines[j] = "";
                //break;  
                j = j + 1;
            }
            if (vacio == true){
                lines[j] = "";
                j = j + 1;
                Debug.Log("Entro al vacio" + j);
                i = 0;
                vacio = false;
            }

            if (j ==5){
                j = 0;
                // 7 9 6 0 2
                if (pantalla.text == "0\n0\n0\n0\n0\n" && bloqueLlave == false){
                    Debug.Log("CONSEGUIDO FELICIDADES");
                    spawner = GameObject.FindWithTag("Spawner");
                    Debug.Log("Hola");
                    //spawner.GetComponent<Spawner>().color(PC.transform.position + new Vector3(2f,2f,0F));
                    itemManager = GameObject.FindWithTag("itemmanager");
                    itemManager.GetComponent<ItemManager>().upColor();
                    bloqueLlave = true;
                }
                //9 6 0
                if (pantalla.text == "0\n0\n0\n" && bloqueMenos == false){
                    Debug.Log("CONSEGUIDO FELICIDADES");
                    spawner = GameObject.FindWithTag("Spawner");
                    Debug.Log("Hola");
                    //spawner.GetComponent<Spawner>().spawnear(menos, PC.transform.position + new Vector3(2f,2f,0F));
                    itemManager = GameObject.FindWithTag("itemmanager");
                    itemManager.GetComponent<ItemManager>().upMenos();
                    bloqueMenos = true;
                }
                return;
            }
            //i = i + 1;
            // Acceder a cada hijo y realizar las operaciones necesarias
            iteracion += 1;
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
            //Debug.Log("MENSAJE ES: " + mensaje);
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                if (CompareBeginOfStringsWithSubstring(mensaje,"agua(")){
                    Debug.Log("Función Sumar clásica");
                    Debug.Log(mensaje);
                    if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                        mensaje = RemoveStringStart(mensaje, "agua(");
                        mensaje = RemoveStringEnd(mensaje, ")");
                        Debug.Log(mensaje);
                        sumar(mensaje);
                    } else {
                        Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
                    }
                    return;
                } else if (CompareBeginOfStringsWithSubstring(mensaje,"restar(")){
                    Debug.Log("Función Restar clásica");
                    Debug.Log(mensaje);
                    if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                        mensaje = RemoveStringStart(mensaje, "restar(");
                        mensaje = RemoveStringEnd(mensaje, ")");
                        Debug.Log(mensaje);
                        sustraer(mensaje);
                    } else {
                        Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
                    }
                    return;
                } else {
                    blockPrint(mensaje);
                }
            } else if (mensaje == ""){
                
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
            
        } else if (tipo == "sumar"){
            mensaje = RemoveStringStart(mensaje, "agua(");
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                sumar(mensaje);
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
        } else if (tipo == "sumar2"){
            mensaje = RemoveStringStart(mensaje, "agua(");
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                sumar2(mensaje);
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
        } else if (tipo == "pro"){
            mensaje = RemoveStringStart(mensaje, "pro(");
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                pro(mensaje);
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
        } else if (tipo == "llave"){
            mensaje = RemoveStringStart(mensaje, "llave(");
            if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                mensaje = RemoveStringEnd(mensaje, ")");
                llave(mensaje);
            } else {
                Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
            }
        } else if (tipo == "variable"){
            if (!mensaje.StartsWith("mosca=")){
                //Debug.Log("Error de sintaxis. Intenta otra vez.");
                return;
            }
            mensaje = EliminarEspacios(mensaje);
            //Debug.Log(mensaje);
            mensaje = RemoveStringStart(mensaje, "mosca=");
            //Debug.Log(mensaje);
            //Debug.Log(CompareBeginOfStringsWithSubstring(mensaje, "restar"));
            if (CompareBeginOfStringsWithSubstring(mensaje, "restar")){
                mensaje = RemoveStringStart(mensaje, "restar(");
                if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                    mensaje = RemoveStringEnd(mensaje, ")");
                    //Debug.Log("Se van a restar: " + mensaje);
                    restar(mensaje);
                } else {
                    Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
                }
            }
            if (CompareBeginOfStringsWithSubstring(mensaje, "agua")){
                mensaje = RemoveStringStart(mensaje, "agua(");
                if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                    mensaje = RemoveStringEnd(mensaje, ")");
                    //Debug.Log("Se van a restar: " + mensaje);
                    sumar2(mensaje);
                } else {
                    Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
                }
            }
            if (CompareBeginOfStringsWithSubstring(mensaje, "mult")){
                mensaje = RemoveStringStart(mensaje, "mult(");
                if (CompareEndOfStringsWithSubstring2(mensaje, ")")){
                    mensaje = RemoveStringEnd(mensaje, ")");
                    //Debug.Log("Se van a restar: " + mensaje);
                    mult(mensaje);
                } else {
                    Debug.Log("La sintaxis no es correcta, por favor intentar de nuevo");
                }
            }
        }
        
        else {
            Debug.Log("No tenemos la orden de printear");
        }
    }

    private void blockPrint(string mensaje){
        //Debug.Log("Debo printear algo");
        Debug.Log("El mensaje es: " + mensaje);
        string res = string.Join(" ", A);
        //Debug.Log(res);
        //Debug.Log(A[1]);
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

    public bool CompareBeginOfStringsWithSubstring(string strings, string substring)
    {
        return strings.StartsWith(substring);
    }

    //Verifica si un String termina con un Substring dado
    public bool CompareEndOfStringsWithSubstring2(string str, string substring)
    {
        return str.EndsWith(substring);
    }

    //Printea todos los elementos de un String separados por comas
    private void SeparadorComa(string inputString){
        string[] substrings = inputString.Split(',');
        int c = 0;
        foreach (string substring in substrings)
        {
            if (c != 0){
                pantalla.text += ",";
            }
            c =1;
            int valor;
            //Debug.Log(substring);
            AnalisisComa(substring);
            Console.WriteLine(substring.Trim());
            Debug.Log("Esta es la variable: " + substring.Trim());
            bool aux1 = Array.Exists(animales, element => element.Equals(substring.Trim()));
            bool aux2 = Array.Exists(dispositivos, element => element.Equals(substring.Trim()));
            Debug.Log(aux1);
            if (aux1){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, substring.Trim());
                valor = animalesValores[pos1];
                Debug.Log("El valor de " + substring + " es: " + valor);
                pantalla.text += valor;
            } else if (aux2) {
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(dispositivos, substring.Trim());
                Debug.Log("El valor de " + substring + " es: " + dispositivos[pos1]);
                pantalla.text += dispositivos[pos1];
            }
         }
         pantalla.text += "\n";
    }


    private void AnalisisComa(string substring){
        if (AnalisisCorchetes(substring).Item1 == true){
            try{
                //Debug.Log(substring[0]);
                int num = Array.IndexOf(abecedario, "Z");
            } catch {
            }
            //Debug.Log("Veremos si el primer caracter de " + substring +  "es una letra");
            string letter = substring[0].ToString();
            bool aux = Array.Exists(abecedario, element => element.Equals(letter));
            if (aux) {
                //Debug.Log("ES UNA LETRA");
                //Debug.Log(letter + " es un Arreglo");
            } else {
                //Debug.Log("NO LO ES");
                letter = substring[1].ToString();
                //Debug.Log(letter + " es un Arreglo");
            }
            //Debug.Log(substring[1] + " es un Arreglo");
            
            int ind1 = AnalisisCorchetes(substring).Item2 + 1;
            //Debug.Log("Primer corchete está en: " + AnalisisCorchetes(substring).Item2);
            //Debug.Log("Segundo corchete está en: " + AnalisisCorchetes(substring).Item3);

            if (AnalisisCorchetes(substring).Item2 + 1 != AnalisisCorchetes(substring).Item3){
                string aver = ObtenerSubstring(substring, AnalisisCorchetes(substring).Item2 + 1, AnalisisCorchetes(substring).Item3);
                int indice = int.Parse(aver);
                int numLetra = Array.IndexOf(abecedario, letter);
                //Debug.Log("La letra " + letter + " está en la posición " + numLetra + " del abecedario");
                //Debug.Log(numLetra);
                //Debug.Log(indice);
                //Debug.Log(letras.Length);
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

    /*------------------------------------------------------------- Funciones auxiliares para la funcionalidad de SUMAR -------------------------------------------------------------*/

    private void sumar(string mensaje){

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay una sola coma, se puede realizar la sumna");
            string str1, str2;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            bool aux1 = Array.Exists(animales, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            if (aux1 && aux2){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, str1);
                int pos2 = Array.IndexOf(animales, str2);
                if (pos1 != pos2){
                    int suma = animalesValores[pos1] + animalesValores[pos2];
                    Debug.Log("La suma de " + str1 + " y de "+ str2 + " es igual a " +suma);
                    pantalla.text += suma + "\n";
                } else {
                    //Debug.Log("Suma prohibida");
                    pantalla.text += "Suma prohibida \n";
                }
                

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

    private void sustraer(string mensaje){

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay una sola coma, se puede realizar la sumna");
            string str1, str2;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            bool aux1 = Array.Exists(animales, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            if (aux1 && aux2){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, str1);
                int pos2 = Array.IndexOf(animales, str2);
                if (pos1 != pos2){
                    int suma = animalesValores[pos1] - animalesValores[pos2];
                    Debug.Log("La resta de " + str1 + " y de "+ str2 + " es igual a " +suma);
                    pantalla.text += suma + "\n";
                } else {
                    //Debug.Log("Suma prohibida");
                    pantalla.text += "Resta prohibida \n";
                }
                

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

    

    

    private bool contarComas(string texto, int num){
        int contador = 0;
        foreach (char caracter in texto)
        {
            if (caracter == ',')
            {
                contador++;
            }
        }
        if (contador == num){
            return true;
        } else {
            return false;
        }
    }

    private (string, string) SepararComas(string mensaje){
        string[] substrings = mensaje.Split(',');
        string str1 ="Hola";
        string str2 ="Chao";
        int i = 0;
        foreach (string substring in substrings)
        {
            //Debug.Log(substring);
            //AnalisisComa(substring);
            //Console.WriteLine(substring.Trim());
            if (i == 0){
                str1 = substring;
                i = i + 1;
            } else {
                str2 = substring;
            }
        }
        return (str1, str2);
    }

    static string EliminarEspacios(string texto)
    {
        return texto.Replace(" ", "");
    }

    /*------------------------------------------------------------- Funciones auxiliares para la funcionalidad de PRODUCTO -------------------------------------------------------------*/

    private void pro(string mensaje){

        if (contarComas(mensaje, 2)){
            //Debug.Log("Hay 2 comas, se puede realizar el producto y asignación");
            string str1, str2, str3;
            str1 = EliminarEspacios(SepararComas2(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas2(mensaje).Item2);
            str3 = EliminarEspacios(SepararComas2(mensaje).Item3);
            bool aux1;
            if (str1 == "pez"){
                aux1 = true;
            } else {
                aux1 = false;
            }
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            bool aux3 = Array.Exists(animales, element => element.Equals(str3));
            if (aux1 && aux2 && aux3){
                int pos2 = Array.IndexOf(animales, str2);
                int pos3 = Array.IndexOf(animales, str3);
                animalesValores[4] = animalesValores[pos2] * animalesValores[pos3];
                Debug.Log("El nuevo valor de PEZ es " + animalesValores[4]);

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

    private (string, string, string) SepararComas2(string mensaje){
        string[] substrings = mensaje.Split(',');
        string str1 ="Hola";
        string str2 ="Chao";
        string str3 ="XD";
        int i = 0;
        foreach (string substring in substrings)
        {
            if (i == 0){
                str1 = substring;
                i = i + 1;
            } else if (i == 1) {
                str2 = substring;
                i = i + 1;
            } else {
                str3 = substring;
            }
        }
        return (str1, str2, str3);
    }

    /*------------------------------------------------------------- Funciones auxiliares para la funcionalidad de LLAVE -------------------------------------------------------------*/

    private void llave(string mensaje){
        //Debug.Log("Se va a evaluar si la siguiente expresión abre un dispositivo: " + mensaje);

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay 1 comas, se puede verificar si hay una llave y un ");
            string str1, str2, str3;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            //bool aux1;
            bool aux1 = Array.Exists(dispositivos, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            
            //Debug.Log(str1 + aux1);
            //Debug.Log(str2 + aux2);
            if (aux1 && aux2){
                
                int pos1 = Array.IndexOf(dispositivos, str1);
                int pos2 = Array.IndexOf(animales, str2);
                int key = animalesValores[pos2];
                bool check1 = Array.Exists(dispositivosClaves, element => element.Equals(key));
                //Debug.Log("Se introdujo la clave " + key + " a " + str1);
                //Debug.Log(check1);
                //Debug.Log(dispositivosClaves[0]);
                if (check1) {
                    int pos3 = Array.IndexOf(dispositivosClaves, key);
                    if (pos1 == pos3){
                        Debug.Log("Contraseña correcta, la clave de " + dispositivos[pos3] + " era " + key);
                        //Debug.Log(controlador.GetComponent<Dispositivos>().dispositivosS[pos3] + ": " + controlador.GetComponent<Dispositivos>().dispositivosB[pos3]);
                        controlador.GetComponent<Dispositivos>().abrir(pos1);
                        Debug.Log(controlador.GetComponent<Dispositivos>().dispositivosS[pos3] + ": " + controlador.GetComponent<Dispositivos>().dispositivosB[pos3]);
                    }
                    else {
                        Debug.Log("¡La combinación es incorrecta! Pruebe de nuevo");
                    }
                } else {
                    Debug.Log("¡La combinación es incorrecta! Pruebe de nuevo");
                }
                

            } else {
                Debug.Log("DENEGADO: No se ha introducido una llave válida");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

/*------------------------------------------------------------- Funciones auxiliares para la funcionalidad de LLAVE -------------------------------------------------------------*/

    private void restar(string mensaje){

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay una sola coma, se puede realizar la sumna");
            string str1, str2;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            bool aux1 = Array.Exists(animales, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            if (aux1 && aux2){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, str1);
                int pos2 = Array.IndexOf(animales, str2);
                int resta = animalesValores[pos1] - animalesValores[pos2];
                animalesValores[0] = resta;
                Debug.Log("La resta de " + str1 + " y de "+ str2 + " es igual a " +resta);
                pantalla.text += "La resta de " + str1 + " y de "+ str2 + " es igual a " +resta+ " \n";

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

    private void sumar2(string mensaje){

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay una sola coma, se puede realizar la sumna");
            Debug.Log(mensaje);
            string str1, str2;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            Debug.Log(str1);
            Debug.Log(str2);
            bool aux1 = Array.Exists(animales, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            if (aux1 && aux2){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, str1);
                int pos2 = Array.IndexOf(animales, str2);
                int resta = animalesValores[pos1] + animalesValores[pos2];
                animalesValores[0] = resta;
                Debug.Log("La sumaaa de " + str1 + " y de "+ str2 + " es igual a " +resta);
                pantalla.text += "La sumaaaa de " + str1 + " y de "+ str2 + " es igual a " +resta+ " \n";

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }

     private void mult(string mensaje){

        if (contarComas(mensaje, 1)){
            //Debug.Log("Hay una sola coma, se puede realizar la sumna");
            Debug.Log(mensaje);
            string str1, str2;
            str1 = EliminarEspacios(SepararComas(mensaje).Item1);
            str2 = EliminarEspacios(SepararComas(mensaje).Item2);
            Debug.Log(str1);
            Debug.Log(str2);
            bool aux1 = Array.Exists(animales, element => element.Equals(str1));
            bool aux2 = Array.Exists(animales, element => element.Equals(str2));
            if (aux1 && aux2){
                //Debug.Log("Las variables son correctas");
                int pos1 = Array.IndexOf(animales, str1);
                int pos2 = Array.IndexOf(animales, str2);
                int resta = animalesValores[pos1] * animalesValores[pos2];
                animalesValores[0] = resta;
                Debug.Log("El productoo de " + str1 + " y de "+ str2 + " es igual a " +resta);
                pantalla.text += "El productoo de " + str1 + " y de "+ str2 + " es igual a " +resta+ " \n";

            } else {
                Debug.Log("Error: Alguna variable no existe o hay un problema en la sintaxis. Intenta cambiar el contenido de los bloques");
            }


        } else {
            Debug.Log("La sintaxis de la función es incorrecta. ¿Te habrás equivado en la cantidad de parámetros?");
        }
    }
}
