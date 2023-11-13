using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockMessage : MonoBehaviour
{
    
    public TextMeshProUGUI T1;
    public TextMeshProUGUI T2;
    public TextMeshProUGUI T3;
    //public string type;


    string[] C = new string[] {",","[","]","(",")","'"," "};
    string[] C1 = new string[] {" ", " "};
    string[] C2 = new string[] {")",","};
    string[] arr = new string[] {",","[","]","(",")","'"," "};
    string[] num = new string[] {"0","1","2","3","4"};
    string[] animales = {"mosca","rata", "gato", "perro", "pez"}; 
    string[] colores = {"'azul'","'verde'","'lila'","'rosa'","'rojo'"}; 
    string[] palabras = {"pluma","mixto","fuego","polen","huevo"}; 
    string[] alphabet = new string[]
    {
        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
        "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", " "
    };
    int i;
    int j;
    int k;
    int len1;
    int len2;
    int len3;

    // Strings para bloque ARREGLO
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (this.tag == "arreglo"){
            C = new string[] {","," "};
        }
        i = 0;
        j = 0;
        k = 0;
       // if (type == "print"){
        //        T1.text = " ";
        //        T2.text = "print";
        //        T3.text = "(";
        //} else {
            //alphabet[2]="V";
        //    T1.text = C[i];
        //    T2.text = alphabet[j];
        //    T3.text = C[0];
        //}
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (this.tag == "bloque"){
            T1.text = C[i];
            T2.text = alphabet[j];
            T3.text = C[k];
            //len3 = alphabet.Length;
            len3 = C.Length;
            len2 = alphabet.Length;
            len1 = C.Length;
        }
        if (this.tag == "arreglo"){
            T1.text = C[i];
            T2.text = alphabet[j];
            T3.text = "[" + num[k] + "]";
            len3 = num.Length;
            len2 = alphabet.Length;
            len1 = C.Length;
        }
        if (this.tag == "animal"){
            T1.text = C1[i];
            T2.text = animales[j];
            T3.text = C2[k];
            len1 = C1.Length;
            len3 = C2.Length;
            len2 = animales.Length;
        }
        if (this.tag == "color"){
            T1.text = C1[i];
            T2.text = colores[j];
            T3.text = C2[k];
            len1 = C1.Length;
            len3 = C2.Length;
            len2 = colores.Length;
        }
        if (this.tag == "letra"){
            T2.text = alphabet[j];
            len2 = alphabet.Length;
        }
        if (this.tag == "num"){
            T2.text = num[j];
            T3.text = C2[k];
            len2 = num.Length;
            len3 = C2.Length;
        }
        if (this.tag == "palabras"){
            T2.text = palabras[j] ;
            T3.text = C2[k];
            len2 = palabras.Length;
            len3 = C2.Length;
        }
        
    }

    public void upLeft(){
        //Debug.Log(C.Length);
        //Debug.Log(i);
        if (i == len1 - 1){
            i = 0;
        }else{
            i = i +1;
        }
    }

    public void upCenter(){
        //Debug.Log(alphabet.Length);
        //Debug.Log(j);
        if (j == len2 - 1){
            j = 0;
        }else{
            j = j +1;
        }
    }

    public void upRight(){
        //Debug.Log(C.Length);
        //Debug.Log(k);
        if (k == len3 - 1){
            k = 0;
        }else{
            k = k +1;
        }
    }

    public void downLeft(){
        //Debug.Log(C.Length);
        //Debug.Log(i);
        if (i == 0){
            i = len1 - 1;
        }else{
            i = i -1;
        }
    }

    public void downCenter(){
        //Debug.Log(alphabet.Length);
        //Debug.Log(i);
        if (j == 0){
            j = len2 - 1;
        }else{
            j = j -1;
        }
    }

    public void downRight(){
        //Debug.Log(C.Length);
        if (k == 0){
            k = len3 - 1;
        }else{
            k = k -1;
        }
    }
    
}
