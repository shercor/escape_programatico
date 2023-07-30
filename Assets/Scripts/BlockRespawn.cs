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
            if (sumar != null)
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
            if (var != null)
            {
                GameObject nuevoHijo = Instantiate(var, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 2){
            if (restar != null)
            {
                GameObject nuevoHijo = Instantiate(restar, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 3){
            if (animal != null)
            {
                GameObject nuevoHijo = Instantiate(animal, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 4){
            if (pro != null)
            {
                GameObject nuevoHijo = Instantiate(pro, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 5){
            if (color != null)
            {
                GameObject nuevoHijo = Instantiate(color, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 6){
            if (llave != null)
            {
                GameObject nuevoHijo = Instantiate(llave, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        return;   
    }
}