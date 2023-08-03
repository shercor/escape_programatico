using UnityEngine;

public class DocRespawn : MonoBehaviour
{

    int i = 0;
    string[] tipos = new string[] {"print", "bloque", "arreglo", "sumar", "animal", "arreglo"};
    public GameObject sumar, tren1, tren2, barco;
    public bool sumarB, tren1B, tren2B, barcoB;
    void Start()
    {
        // Comenzamos el conteo de los hijos directos del objeto raíz
        sumarB = false;
        //ContarHijosDirectos(transform);
        
    }

    void Update(){
        i = 0;
        ContarHijosDirectos(transform);
    }

    // Función para contar e imprimir los hijos directos de un objeto
    void ContarHijosDirectos(Transform objeto)
    {
        int cantidadHijosDirectos = objeto.childCount;
        if (objeto.tag == "slot" ){
                if (cantidadHijosDirectos == 0){
                    Spawnear(i);
                } else if (cantidadHijosDirectos == 2 && objeto.tag!= "doc"){
                    Destroy(objeto.gameObject.transform.GetChild(0).gameObject);
                } else {
                    //Debug.Log("El hijo numero " + i + " tiene tag: " + objeto.gameObject.transform.GetChild(0).tag);
                    if (i == 8){
                        //Destroy(objeto.gameObject.transform.GetChild(0).gameObject);
                    }
                }
                i = i + 1;
            }

        // Recorremos los hijos del objeto actual
        foreach (Transform hijo in objeto)
        {
            // Llamamos a la función para cada hijo directo del objeto actual
            if (hijo.tag == "slot"){
                ContarHijosDirectos(hijo);
            }
            
        }
    }

    private void Spawnear(int n){
        if (n == 0){
            if (sumar != null && sumarB == true)
            {
                GameObject nuevoHijo = Instantiate(sumar, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 1){
            if (tren1 != null && tren1B == true)
            {
                GameObject nuevoHijo = Instantiate(tren1, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 2){
            if (tren2 != null && tren2B == true)
            {
                GameObject nuevoHijo = Instantiate(tren2, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
            if (n == 3){
            if (barco != null && barcoB == true)
            {
                GameObject nuevoHijo = Instantiate(barco, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
    }

    public void activarItem(string item){
        if (item == "doc_sumar"){
            Debug.Log("Se va a activar el DOC1: " + sumarB);
            sumarB = true;
            Debug.Log("Se activó DOC1: " + sumarB);
        }
        if (item == "doc_tren1"){
            Debug.Log("Se va a activar el DOC1: " + tren1B);
            tren1B = true;
            Debug.Log("Se activó DOC1: " + tren1B);
        }
        if (item == "doc_tren2"){
            Debug.Log("Se va a activar el DOC1: " + tren2B);
            tren2B = true;
            Debug.Log("Se activó DOC1: " + tren2B);
        }
        if (item == "doc_barco"){
            Debug.Log("Se va a activar el DOC1: " + barcoB);
            barcoB = true;
            Debug.Log("Se activó DOC1: " + barcoB);
        }
    }
}