using UnityEngine;

public class DocRespawn : MonoBehaviour
{

    int i = 0;
    string[] tipos = new string[] {"print", "bloque", "arreglo", "sumar", "animal", "arreglo"};
    public GameObject sumar, tren1, tren2, barco, sol1, sol2, sol3, sol4, agua, helio, litio;
    public bool sumarB, tren1B, tren2B, barcoB, sol1B, sol2B, sol3B, sol4B, aguaB, helioB, litioB;
    void Start()
    {
        // Comenzamos el conteo de los hijos directos del objeto raíz
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
            if (agua != null && aguaB == true)
            {
                Debug.Log("Se va a spawnear Newton (Sumar)");
                GameObject nuevoHijo = Instantiate(agua, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 1){
            if (helio != null && helioB == true)
            {
                GameObject nuevoHijo = Instantiate(helio, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 2){
            if (litio != null && litioB == true)
            {
                GameObject nuevoHijo = Instantiate(litio, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 3){
            if (sol1 != null && sol1B == true)
            {
                GameObject nuevoHijo = Instantiate(sol1, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 4){
            if (sol2 != null && sol2B == true)
            {
                GameObject nuevoHijo = Instantiate(sol2, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 5){
            if (sol3 != null && sol3B == true)
            {
                GameObject nuevoHijo = Instantiate(sol3, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 6){
            if (sol4 != null && sol4B == true)
            {
                GameObject nuevoHijo = Instantiate(sol4, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
    }

    public void activarItem(string item){
        GameObject camaraPrincipal = GameObject.FindGameObjectWithTag("MainCamera");
        if (item == "doc_agua"){
            Debug.Log("Se va a activar el DOC1: " + aguaB);
            aguaB = true;
            Debug.Log("Se activó DOC1: " + aguaB);
            Debug.Log(sumar);
            Debug.Log(sumarB);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'Agua'!");
        }
        if (item == "doc_helio"){
            Debug.Log("Se va a activar el DOC1: " + tren1B);
            helioB = true;
            Debug.Log("Se activó DOC1: " + tren1B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'Helio'!");
        }
        if (item == "doc_litio"){
            Debug.Log("Se va a activar el DOC1: " + tren2B);
            litioB = true;
            Debug.Log("Se activó DOC1: " + tren2B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'Litio'!");
        }
        if (item == "doc_barco"){
            Debug.Log("Se va a activar el DOC1: " + barcoB);
            barcoB = true;
            Debug.Log("Se activó DOC1: " + barcoB);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'Barco'!");
        }
        if (item == "doc_sol1"){
            Debug.Log("Se va a activar el DOC: " + sol1B);
            sol1B = true;
            Debug.Log("Se activó DOC: " + sol1B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'SOL' 1!");
        }
        if (item == "doc_sol2"){
            Debug.Log("Se va a activar el DOC: " + sol2B);
            sol2B = true;
            Debug.Log("Se activó DOC: " + sol2B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'SOL' 2!");
        }
        if (item == "doc_sol3"){
            Debug.Log("Se va a activar el DOC: " + sol3B);
            sol3B = true;
            Debug.Log("Se activó DOC: " + sol3B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'SOL' 3!");
        }
        if (item == "doc_sol4"){
            Debug.Log("Se va a activar el DOC: " + sol4B);
            sol4B = true;
            Debug.Log("Se activó DOC: " + sol4B);
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el Documento 'SOL' 4!");
        }
    }
}