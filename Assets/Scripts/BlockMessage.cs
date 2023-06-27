using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockMessage : MonoBehaviour
{
    
    public TextMeshProUGUI T1;
    public TextMeshProUGUI T2;
    public TextMeshProUGUI T3;
    string[] C = new string[] {"[","]",",","(",")","'"," "};
    string[] alphabet = new string[]
    {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
        "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "="
    };
    int i;
    int j;
    int k;
    
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        j = 0;
        k = 0;
        //alphabet[2]="V";
        T1.text = C[i];
        T2.text = alphabet[j];
        T3.text = C[0];
    }

    // Update is called once per frame
    public void Update()
    {
        T1.text = C[i];
        T2.text = alphabet[j];
        T3.text = C[k];
    }

    public void upLeft(){
        Debug.Log(C.Length);
        Debug.Log(i);
        if (i == C.Length - 1){
            i = 0;
        }else{
            i = i +1;
        }
    }

    public void upCenter(){
        Debug.Log(alphabet.Length);
        Debug.Log(j);
        if (j == alphabet.Length - 1){
            j = 0;
        }else{
            j = j +1;
        }
    }

    public void upRight(){
        Debug.Log(C.Length);
        Debug.Log(k);
        if (k == C.Length - 1){
            k = 0;
        }else{
            k = k +1;
        }
    }

    public void downLeft(){
        Debug.Log(C.Length);
        Debug.Log(i);
        if (i == 0){
            i = C.Length - 1;
        }else{
            i = i -1;
        }
    }

    public void downCenter(){
        Debug.Log(alphabet.Length);
        Debug.Log(i);
        if (j == 0){
            j = alphabet.Length - 1;
        }else{
            j = j -1;
        }
    }

    public void downRight(){
        Debug.Log(C.Length);
        Debug.Log(i);
        if (k == 0){
            k = C.Length - 1;
        }else{
            k = k -1;
        }
    }
    
}
