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
    string[] arr = new string[] {",","[","]","(",")","'"," "};
    string[] num = new string[] {"1","2","3","4","5","6","7","8","8","9"};
    string[] alphabet = new string[]
    {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
        "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " "
    };
    int i;
    int j;
    int k;
    int ln;

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
            //ln = alphabet.Length;
            ln = C.Length;
        }
        if (this.tag == "arreglo"){
            T1.text = C[i];
            T2.text = alphabet[j];
            T3.text = "[" + num[k] + "]";
            ln = num.Length;
        }
        
    }

    public void upLeft(){
        //Debug.Log(C.Length);
        //Debug.Log(i);
        if (i == C.Length - 1){
            i = 0;
        }else{
            i = i +1;
        }
    }

    public void upCenter(){
        //Debug.Log(alphabet.Length);
        //Debug.Log(j);
        if (j == alphabet.Length - 1){
            j = 0;
        }else{
            j = j +1;
        }
    }

    public void upRight(){
        //Debug.Log(C.Length);
        //Debug.Log(k);
        if (k == ln - 1){
            k = 0;
        }else{
            k = k +1;
        }
    }

    public void downLeft(){
        //Debug.Log(C.Length);
        //Debug.Log(i);
        if (i == 0){
            i = C.Length - 1;
        }else{
            i = i -1;
        }
    }

    public void downCenter(){
        //Debug.Log(alphabet.Length);
        //Debug.Log(i);
        if (j == 0){
            j = alphabet.Length - 1;
        }else{
            j = j -1;
        }
    }

    public void downRight(){
        //Debug.Log(C.Length);
        Debug.Log(this.tag);
        if (k == 0){
            k = ln - 1;
        }else{
            k = k -1;
        }
    }
    
}
