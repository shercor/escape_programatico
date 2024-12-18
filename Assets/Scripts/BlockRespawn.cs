using UnityEngine;

public class BlockRespawn : MonoBehaviour
{
    int i = 0;
    string[] tipos = new string[] {"print", "bloque", "arreglo", "sumar", "animal", "arreglo"};
    public GameObject print;
    public GameObject bloque;
    public GameObject arreglo;
    public GameObject sumar;
    public GameObject animal;
    public GameObject pro;
    public GameObject llave;
    public GameObject color;
    public GameObject restar;
    public GameObject var;
    public GameObject sumar2;
    public GameObject mult;
    public GameObject parentesis;
    public GameObject sol;
    private bool printB = true;
    private bool parentesisB = true;
    private bool bloqueB;
    private bool arregloB;
    private bool sumarB;
    private bool animalB;
    private bool proB;
    private bool llaveB;
    private bool colorB;
    private bool restarB;
    private bool varB;
    private bool sumar2B;
    private bool multB;
    private bool solB;

    void Start()
    {
        // Comenzamos el conteo de los hijos directos del objeto raíz
        ContarHijosDirectos(transform);
    }

    void Update(){
        i = 0;
        ContarHijosDirectos(transform);
    }

    // Función para contar e imprimir los hijos directos de un objeto
    void ContarHijosDirectos(Transform objeto)
    {
        int cantidadHijosDirectos = objeto.childCount;
        if (objeto.tag == "slot"){
                if (cantidadHijosDirectos == 0){
                    Spawnear(i);
                } else if (cantidadHijosDirectos == 2){
                    Destroy(objeto.gameObject.transform.GetChild(0).gameObject);
                } else {
                    //Debug.Log("El hijo numero " + i + " tiene tag: " + objeto.gameObject.transform.GetChild(0).tag);
                    if (i == 10){
                        Destroy(objeto.gameObject.transform.GetChild(0).gameObject);
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
            if (print != null && printB == true)
            {
                GameObject nuevoHijo = Instantiate(print, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 7){
            if (var != null && varB == true)
            {
                GameObject nuevoHijo = Instantiate(var, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 4){
            if (restar != null && restarB == true)
            {
                GameObject nuevoHijo = Instantiate(restar, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 3){
            if (animal != null && animalB == true)
            {
                GameObject nuevoHijo = Instantiate(animal, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }

        if (n == 5){
            if (color != null && colorB == true)
            {
                GameObject nuevoHijo = Instantiate(color, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 8){
            if (llave != null && llaveB == true)
            {
                GameObject nuevoHijo = Instantiate(llave, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 2){
            if (sumar2 != null && sumar2B == true)
            {
                GameObject nuevoHijo = Instantiate(sumar2, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 6){
            if (mult != null && multB == true)
            {
                GameObject nuevoHijo = Instantiate(mult, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 1){
            if (parentesis != null && parentesisB == true)
            {
                GameObject nuevoHijo = Instantiate(parentesis, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 9){
            Debug.Log("Spaenwar sol");
            if (sol != null && solB == true)
            {
                GameObject nuevoHijo = Instantiate(sol, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        return;   
    }
        /*
        private bool printB;
        private bool bloqueB;
        private bool arregloB;
        private bool sumarB;
        private bool animalB;
        private bool proB;
        private bool llaveB;
        private bool colorB;
        private bool restarB;
        */


        public void activarItem(string item){
        GameObject camaraPrincipal = GameObject.FindGameObjectWithTag("MainCamera");
        if (item == "sumar"){
            sumarB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Agua!");
        }
        if (item == "bloque"){
            bloqueB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Bloque!");
        }
        if (item == "animal"){
            animalB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Animales!");
        }
        if (item == "pro"){
            proB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Litio!");
        }
        if (item == "llave"){
            llaveB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Llave!");
        }
        if (item == "color"){
            colorB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Colores!");
        }
        if (item == "restar"){
            restarB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Helio!");
        }
        if (item == "var"){
            varB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Variable!");
        }
        if (item == "sumar2"){
            sumar2B = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Agua!");
        }
        if (item == "mult"){
            multB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque Litio!");
        }
        if (item == "sol"){
            solB = true;
            camaraPrincipal.GetComponent<Alerta>().MostrarAlerta("¡Han obtenido el bloque SOL!");
        }
        
        
    }
}