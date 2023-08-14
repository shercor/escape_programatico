using UnityEngine;

public class BlockRespawnESP : MonoBehaviour
{
    int i = 0;
    string[] tipos = new string[] {"word", "bloque", "arreglo", "sumar", "palabras", "arreglo"};
    public GameObject word;
    public GameObject bloque;
    public GameObject arreglo;
    public GameObject sumar;
    public GameObject palabras;
    public GameObject pro;
    public GameObject llave;
    public GameObject color;
    public GameObject restar;
    public GameObject var;
    public GameObject num;
    public GameObject mult;
    public GameObject ext;
    private bool wordB = true;
    private bool extB = true;
    private bool bloqueB;
    private bool arregloB;
    private bool sumarB;
    private bool palabrasB = true;
    private bool proB;
    private bool llaveB;
    private bool colorB;
    private bool restarB;
    private bool varB;
    private bool numB = true;
    private bool multB;

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
            if (word != null && wordB == true)
            {
                GameObject nuevoHijo = Instantiate(word, transform.position, Quaternion.identity);
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
            if (palabras != null && palabrasB == true)
            {
                GameObject nuevoHijo = Instantiate(palabras, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }
        if (n == 2){
            if (num != null && numB == true)
            {
                GameObject nuevoHijo = Instantiate(num, transform.position, Quaternion.identity);
                nuevoHijo.transform.parent = transform.GetChild(n).gameObject.transform;
            }
            else
            {
                //Debug.LogError("Prefab no asignado. Por favor, asigna un prefab válido en el Inspector.");
            }
        }

        if (n == 1){
            if (ext != null && extB == true)
            {
                GameObject nuevoHijo = Instantiate(ext, transform.position, Quaternion.identity);
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
        private bool wordB;
        private bool bloqueB;
        private bool arregloB;
        private bool sumarB;
        private bool palabrasB;
        private bool proB;
        private bool llaveB;
        private bool colorB;
        private bool restarB;
        */


        public void activarItem(string item){
        if (item == "sumar"){
            sumarB = true;
        }
        if (item == "bloque"){
            bloqueB = true;
        }
        if (item == "palabras"){
            palabrasB = true;
        }
        if (item == "pro"){
            proB = true;
        }
        if (item == "llave"){
            llaveB = true;
        }
        if (item == "color"){
            colorB = true;
        }
        if (item == "restar"){
            restarB = true;
        }
        if (item == "var"){
            varB = true;
        }
        if (item == "num"){
            numB = true;
        }
        if (item == "mult"){
            multB = true;
        }
    }
}